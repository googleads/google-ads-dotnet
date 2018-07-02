@echo off
echo Build the library.
echo ==================

dotnet build ..\src\Google.Ads.GoogleAds.csproj

echo Build the examples.
echo ===================
dotnet build ..\examples\Services\Google.Ads.GoogleAds.Examples.csproj

echo Run the tests.
echo ==============
dotnet build ..\tests\Google.Ads.GoogleAds.Tests.csproj
@echo on

exit /b %ERRORLEVEL%

