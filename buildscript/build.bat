@echo off

:: Save the path of the build script.
set BuildScriptPath=%~dp0

:: Strip trailing backslash.
set RootPath=%BuildScriptPath:~0,-1%\..

echo Build the library.
echo ==================

dotnet build --configuration Release "%RootPath%\src\Google.Ads.GoogleAds.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

echo Build the examples.
echo ===================
dotnet build --configuration Release "%RootPath%\examples\Google.Ads.GoogleAds.Examples.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

echo Build the authentication projects.
echo ==================================
dotnet build --configuration Release "%RootPath%\examples\Authentication\AuthenticateInDesktopApplication\AuthenticateInDesktopApplication.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

dotnet build --configuration Release "%RootPath%\examples\Authentication\AuthenticateInWebApplication\AuthenticateInWebApplication.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

echo Run the tests.
echo ==============
dotnet build --configuration Release "%RootPath%\tests\Google.Ads.GoogleAds.Tests.csproj"
if %errorlevel% neq 0 exit /b %errorlevel%

echo Run the smoke tests.
echo ===================
dotnet test "%RootPath%\tests\bin\Release\netcoreapp3.0\Google.Ads.GoogleAds.Tests.dll" -v d --filter TestCategory=Smoke
if %errorlevel% neq 0 exit /b %errorlevel%
@echo on
exit /b 0
