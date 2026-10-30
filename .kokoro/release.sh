#!/bin/bash
set -euo pipefail

DRY_RUN="${DRY_RUN:-true}"
if [[ "${DRY_RUN}" != "true" && "${DRY_RUN}" != "false" ]]; then
  echo "ERROR: DRY_RUN must be 'true' or 'false' (got '${DRY_RUN}')." >&2
  exit 1
fi

REPO_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "${REPO_DIR}"

echo "=== Building and Releasing from: ${REPO_DIR} (DRY_RUN=${DRY_RUN}) ==="

export DOTNET_CLI_TELEMETRY_OPTOUT=true
export DOTNET_NOLOGO=true

if ! command -v dotnet &> /dev/null; then
  DOTNET_VERSION="8.0.414"
  DOTNET_FILE="dotnet-sdk-${DOTNET_VERSION}-linux-x64.tar.gz"
  DOTNET_SHA512="bdf6b151f787ac57d393e625e8b8fc8e19ac75902e76227da736f20e042cf7ff98bfd1a6669b77fdea7bfe678a0f23103e0cace1db83e9aee568ccd6f1b5b264"
  DOTNET_DOWNLOAD_DIR="$(mktemp -d)"
  echo "=== Downloading .NET SDK ${DOTNET_VERSION} ==="
  curl -fsSL "https://builds.dotnet.microsoft.com/dotnet/Sdk/${DOTNET_VERSION}/${DOTNET_FILE}" -o "${DOTNET_DOWNLOAD_DIR}/${DOTNET_FILE}"
  echo "=== Verifying SHA-512 of .NET SDK ${DOTNET_VERSION} ==="
  echo "${DOTNET_SHA512}  ${DOTNET_DOWNLOAD_DIR}/${DOTNET_FILE}" | sha512sum --check --strict
  export DOTNET_ROOT="$(mktemp -d)"
  tar -xzf "${DOTNET_DOWNLOAD_DIR}/${DOTNET_FILE}" -C "${DOTNET_ROOT}"
  rm -rf "${DOTNET_DOWNLOAD_DIR}"
  export PATH="${DOTNET_ROOT}:${PATH}"
fi

dotnet --info

EXIT_GATE_PROJECT="oss-exit-gate-prod"
EXIT_GATE_LOCATION="us"
EXIT_GATE_REPOSITORY="google-ads-dotnet--nuget"

pack_and_stage() {
  local csproj="$1"
  local pkg_id="$2"
  local pkg_ver
  pkg_ver="$(sed -n 's/.*<Version>\(.*\)<\/Version>.*/\1/p' "${csproj}" | tr -d '[:space:]')"
  if [[ -z "${pkg_ver}" ]]; then
    echo "ERROR: Could not extract <Version> from ${csproj}" >&2
    exit 1
  fi
  local out_dir="artifacts/${pkg_id}"
  rm -rf "${out_dir}"
  mkdir -p "${out_dir}"
  dotnet pack "${csproj}" -c Release -o "${out_dir}" >&2

  if gcloud artifacts packages describe "${pkg_id}" \
      --project="${EXIT_GATE_PROJECT}" \
      --location="${EXIT_GATE_LOCATION}" \
      --repository="${EXIT_GATE_REPOSITORY}" &>/dev/null; then
    gcloud artifacts packages delete "${pkg_id}" \
      --project="${EXIT_GATE_PROJECT}" \
      --location="${EXIT_GATE_LOCATION}" \
      --repository="${EXIT_GATE_REPOSITORY}" \
      --quiet >&2
  fi

  gcloud artifacts generic upload \
    --project="${EXIT_GATE_PROJECT}" \
    --location="${EXIT_GATE_LOCATION}" \
    --repository="${EXIT_GATE_REPOSITORY}" \
    --package="${pkg_id}" \
    --version="${pkg_ver}" \
    --source-directory="${out_dir}" >&2
  echo "${pkg_ver}"
}

GAX_VER="$(pack_and_stage "Google.Ads.Gax/src/Google.Ads.Gax.csproj" "google.ads.gax")"
CORE_VER="$(pack_and_stage "Google.Ads.GoogleAds.Core/src/Google.Ads.GoogleAds.Core.csproj" "google.ads.googleads.core")"
ADS_VER="$(pack_and_stage "Google.Ads.GoogleAds/src/Google.Ads.GoogleAds.csproj" "google.ads.googleads")"
EXT_VER="$(pack_and_stage "Google.Ads.GoogleAds.Extensions/src/Google.Ads.GoogleAds.Extensions.csproj" "google.ads.googleads.extensions")"

if [[ "${DRY_RUN}" == "true" ]]; then
  echo "=== DRY_RUN is enabled. Skipping manifest upload to Exit Gate. ==="
  exit 0
fi

cat <<EOF > manifest.json
{
  "publish_all": false,
  "publishing_groups": [
    {
      "packages": [
        { "name": "google.ads.gax", "version": "${GAX_VER}" },
        { "name": "google.ads.googleads.core", "version": "${CORE_VER}" },
        { "name": "google.ads.googleads", "version": "${ADS_VER}" },
        { "name": "google.ads.googleads.extensions", "version": "${EXT_VER}" }
      ]
    }
  ]
}
EOF

EXIT_GATE_BUCKET="gs://oss-exit-gate-prod-projects-bucket/google-ads-dotnet/nuget/manifests"
MANIFEST_NAME="manifest-$(date +%Y%m%d%H%M%S).json"

echo "=== Uploading manifest to ${EXIT_GATE_BUCKET}/${MANIFEST_NAME} ==="
gcloud storage cp manifest.json "${EXIT_GATE_BUCKET}/${MANIFEST_NAME}"
