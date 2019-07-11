#!/usr/bin/env bash

BuildScriptPath=$(pwd)
RootPath=$BuildScriptPath/..

echo "Build the library"
dotnet build $RootPath/src/Google.Ads.GoogleAds.csproj

echo "Build the examples"
dotnet build $RootPath/examples/Google.Ads.GoogleAds.examples.csproj

echo "Build the tests"
dotnet build $RootPath/tests/Google.Ads.GoogleAds.Tests.csproj