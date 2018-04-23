# Google Ads Client Library for .NET

This project hosts the .NET client library for the Google Ads API.


## Features

- Stub classes for all the supported API versions and services.
- Easy management of credentials, authentication, and session information.
- Docs available in HTML and XML format.

## Requirements

- .NET Framework 4.5.2+
- .NET Standard 2.0

## Announcements and updates

For API and client library updates and news, please follow our Google
 Ads Developers blog: http://googleadsdeveloper.blogspot.com/.


## Running the code examples

We provide a zip package for the examples. To run the code examples,
 follow these steps:

1. Download the Google.Ads.GoogleAds.Examples zip file from
 https://github.com/googleads/google-ads-dotnet/releases/latest.
1. Extract the examples zip file into a local folder.
1. Open `Google.Ads.GoogleAds.Examples.sln in Visual Studio and build it.
1. Follow the instructions on the
[Authentication guide](https://developers.google.com/google-ads/api/docs/oauth/cloud-project)
 to create an OAuth2 client ID and Secret.
1. Run the `AuthenticateInStandaloneApplication` code example from the
 Visual Studio project. When prompted, provide the client ID and client secret
 from the previous step. `AuthenticateInStandaloneApplication` performs
 the authentication and prints the configuration in XML format. Copy the
 configuration into the `App.config` of the `Google.Ads.Adwords.Examples`
 project.
1. Open the **Properties** dialog for the Examples project by
 right clicking `Google.Ads.GoogleAds.Examples` project in the Solution
 Explorer and selecting the **Properties** option from the context
 menu.
1. Navigate to the **Debug Tab** and enter the command-line options,
 which are of the form `version.examplename`. For instance,
 `V0.GetCampaigns` is the command-line option to run `GetCampaigns`
 in the `V0` version of the AdWords API.
1. Compile and run the `Google.Ads.GoogleAds.Examples` project.

As an alternative to steps 8-10, each code example has a `main()` 
method, so you can set the appropriate code example as the Startup
object (Select the **Application tab** on the Examples Properties dialog
 and pick the desired class from the "Startup object" dropdown.).


## Using the client library in your own project


The client library binaries are distributed via Nuget. Add a Nuget
 reference to the [Google.Ads.GoogleAds package](https://www.nuget.org/packages/Google.Ads.GoogleAds)
 in your project to use the client library.


## How do I make API calls?

```
// Create a Google Ads client.
GoogleAdsClient client = new GoogleAdsClient();

// Create the required service.
CampaignServiceClient campaignService =
    client.GetService(Services.V0.CampaignService);

// make more calls to service class.
```

See the [Getting Started](https://github.com/googleads/google-ads-dotnet/wiki/Getting-started) guide
for more details, and examples folder for code examples that show how to use various services.

## Miscellaneous


### Wiki

- https://github.com/googleads/google-ads-dotnet/wiki

### Issue tracker

- https://github.com/googleads/google-ads-dotnet/issues 

### API Documentation

- https://developers.google.com/google-ads/api/

### Support forum

- https://developers.google.com/adwords/api/community/

### Authors

- https://github.com/AnashOommen
