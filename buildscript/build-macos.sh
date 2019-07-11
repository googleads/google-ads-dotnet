#!/usr/bin/env bash

BuildScriptPath=$(pwd)
RootPath=$BuildScriptPath/..

echo "Build the library"
dotnet build $RootPath/src/Google.Ads.GoogleAds.csproj

echo "Build the examples"
dotnet build $RootPath/examples/Google.Ads.GoogleAds.examples.csproj

echo "Build the tests"
dotnet build $RootPath/tests/Google.Ads.GoogleAds.Tests.csproj

# @echo off

# :: Save the path of the build script.
# set BuildScriptPath=%~dp0

# :: Strip trailing backslash.
# set RootPath=%BuildScriptPath:~0,-1%\..

# echo Build the library.
# echo ==================

# dotnet build "%RootPath%\src\Google.Ads.GoogleAds.csproj"
# if %errorlevel% neq 0 exit /b %errorlevel%

# echo Build the examples.
# echo ===================
# dotnet build "%RootPath%\examples\Google.Ads.GoogleAds.examples.csproj"
# if %errorlevel% neq 0 exit /b %errorlevel%

# echo Run the tests.
# echo ==============
# dotnet build "%RootPath%\tests\Google.Ads.GoogleAds.Tests.csproj"
# if %errorlevel% neq 0 exit /b %errorlevel%

# @echo on
# exit /b 0
