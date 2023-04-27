// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.Gax.Config;
using Google.Ads.GoogleAds.Config;

using Microsoft.Extensions.Configuration;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Google.Ads.GoogleAds.Extensions.Config
{
    /// <summary>
    /// </summary>
    public static class ConfigExtensions
    {

        /// <summary>
        /// Mapping from environment variable names to configuration setting names.
        /// </summary>
        public static readonly ReadOnlyDictionary<string, string> ENV_VAR_TO_CONFIG_KEY_MAP =
            new ReadOnlyDictionary<string, string>(new Dictionary<string, string>() {
            { EnvironmentVariableNames.OAUTH2_MODE, ConfigSettingNames.OAUTH2_MODE },
            { EnvironmentVariableNames.OAUTH2_CLIENT_ID, ConfigSettingNames.OAUTH2_CLIENT_ID },
            {
                EnvironmentVariableNames.OAUTH2_CLIENT_SECRET,
                ConfigSettingNames.OAUTH2_CLIENT_SECRET
            },
            {
                EnvironmentVariableNames.OAUTH2_REFRESH_TOKEN,
                ConfigSettingNames.OAUTH2_REFRESH_TOKEN
            },
            {
                EnvironmentVariableNames.OAUTH2_JSON_KEY_FILE_PATH,
                ConfigSettingNames.OAUTH2_JSON_KEY_FILE_PATH
            },
            {
                EnvironmentVariableNames.OAUTH2_IMPERSONATED_EMAIL,
                ConfigSettingNames.OAUTH2_IMPERSONATED_EMAIL
            },
            { EnvironmentVariableNames.DEVELOPER_TOKEN, ConfigSettingNames.DEVELOPER_TOKEN },
            {
                EnvironmentVariableNames.LOGIN_CUSTOMER_ID,
                ConfigSettingNames.LOGIN_CUSTOMER_ID
            },
            {
                EnvironmentVariableNames.LINKED_CUSTOMER_ID,
                ConfigSettingNames.LINKED_CUSTOMER_ID
            }
        });

        /// <summary>
        /// The configuration section name in App.config file.
        /// </summary>
        public const string CONFIG_SECTION_NAME = "GoogleAdsApi";

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsConfig"/> class.
        /// </summary>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        /// <param name="configurationRoot">The configuration root.</param>
        public static void LoadFromConfigurationRoot(
            this GoogleAdsConfig target,
            IConfigurationRoot configurationRoot)
        {
            target.LoadFromConfiguration(configurationRoot, "");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsConfig"/> class.
        /// </summary>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        /// <param name="configurationSection">The configuration section.</param>
        public static void LoadFromConfigurationSection(
            this GoogleAdsConfig target, IConfigurationSection configurationSection
        )
        {
            target.LoadFromConfiguration(configurationSection, configurationSection.Key);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsConfig"/> class.
        /// </summary>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        /// <param name="configuration">The configuration section.</param>
        /// <param name="sectionName"></param>
        private static void LoadFromConfiguration(
            this GoogleAdsConfig target, IConfiguration configuration, string sectionName
        )
        {
            target.ReadSettings(ToDictionary(configuration, sectionName));
        }

        /// <summary>
        /// Attempts to load the default configuration section.
        /// </summary>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        /// <returns>
        /// True if loading was successful, false otherwise.
        /// </returns>
        public static bool LoadFromDefaultAppConfigSection(this GoogleAdsConfig target)
        {
            return target.LoadFromAppConfigSection(CONFIG_SECTION_NAME);
        }

        /// <summary>
        /// Attempts to load the configuration section with the given name.
        /// </summary>
        /// <param name="sectionName">The name of the configuration section to load.</param>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        /// <returns>
        /// True if loading was successful, false otherwise.
        /// </returns>
        public static bool LoadFromAppConfigSection(this GoogleAdsConfig target, string sectionName)
        {
            Dictionary<string, string> config = ReadAppConfigSection(sectionName);
            if (config.Count == 0)
            {
                return false;
            }

            target.ReadSettings(config);
            return true;
        }

        /// <summary>
        /// Loads the configuration from environment variables.
        /// </summary>
        public static void LoadFromEnvironmentVariables(this GoogleAdsConfig target)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            foreach (string key in ENV_VAR_TO_CONFIG_KEY_MAP.Keys)
            {
                string value = Environment.GetEnvironmentVariable(key);
                if (!string.IsNullOrEmpty(value))
                {
                    settings[ENV_VAR_TO_CONFIG_KEY_MAP[key]] = value;
                }
            }
            target.ReadSettings(settings);
        }

        /// <summary>
        /// Loads configuration from a file path pointed to by a specified environment variable.
        /// </summary>
        /// <param name="environmentVariableName">Name of the environment variable to use.</param>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        public static void TryLoadFromEnvironmentFilePath(this GoogleAdsConfig target, string environmentVariableName,
            string sectionName)
        {
            string filePath = Environment.GetEnvironmentVariable(environmentVariableName);
            if (!string.IsNullOrEmpty(filePath))
            {
                target.LoadFromSettingsJson(filePath, sectionName);
            }
        }

        /// <summary>
        /// Loads the configuration from settings json.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="target">The <see cref="GoogleAdsConfig"/> to update.</param>
        public static void LoadFromSettingsJson(this GoogleAdsConfig target, string filePath, string sectionName)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile(filePath);
            IConfigurationRoot configRoot = builder.Build();
            target.LoadFromConfiguration(configRoot, sectionName);
        }

        /// <summary>
        /// Reads the application configuration section.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <returns>A dictionary with key as configuration keyname and value as configuration
        /// value.</returns>
        private static Dictionary<string, string> ReadAppConfigSection(string sectionName)
        {
            Hashtable config = AppConfigUtilities.GetSection(sectionName);
            return config != null ?
                config.Cast<DictionaryEntry>().ToDictionary(
                    d => d.Key.ToString(), d => d.Value?.ToString()) :
                new Dictionary<string, string>();
            ;
        }

        /// <summary>
        /// Converts a configuration section into a dictionary. Section name prefix is stripped
        /// from the key names.
        /// </summary>
        /// <param name="configuration">The configuration section.</param>
        /// <param name="sectionName">Name of the section.</param>
        /// <returns>A dictionary with key as configuration keyname and value as configuration
        /// value.</returns>
        private static Dictionary<string, string> ToDictionary(IConfiguration configuration,
            string sectionName)
        {
            if (string.IsNullOrEmpty(sectionName))
            {
                return configuration.AsEnumerable().ToDictionary(
                    setting => setting.Key,
                    setting => setting.Value);
            }
            else
            {
                string sectionPrefix = sectionName + ":";
                return configuration.AsEnumerable().ToDictionary(
                    setting => setting.Key.Replace(sectionPrefix, ""),
                    setting => setting.Value);
            }
        }

    }
}