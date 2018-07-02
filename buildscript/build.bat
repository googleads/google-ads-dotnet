@echo off

:: Save the path of the build script.
set BuildScriptPath=%~dp0

:: Strip trailing backslash.
set RootPath=%BuildScriptPath:~0,-1%\..

echo Build the library.
echo ==================

dotnet build "%RootPath%\src\Google.Ads.GoogleAds.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

echo Build the examples.
echo ===================
dotnet build "%RootPath%\examples\Services\Google.Ads.GoogleAds.Examples.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

echo Run the tests.
echo ==============
dotnet build "%RootPath%\tests\Google.Ads.GoogleAds.Tests.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

@echo on
exit /b 0

