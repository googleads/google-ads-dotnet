# Google Ads Client Library for .NET - Migration examples

This folder contains code examples that illustrate how to migrate from the AdWords API to the
Google Ads API in a step-by-step manner. The following code examples are provided.

## CampaignManagement

This folder contains a code example that shows how to create a Google Ads Search campaign. 
The code example does the following operations:

  - Create a budget
  - Create a campaign
  - Create an ad group.
  - Create Text Ads
  - Create keywords

The code example starts with CreateCompleteCampaignAdWordsApiOnly.cs that shows the whole
functionality developed in AdWords API. CreateCompleteCampaignBothApisPhase1.cs through
CreateCompleteCampaignBothApisPhase4.cs shows how to migrate functionality
 incrementally from the AdWords API to the Google Ads API. CreateCompleteCampaignGoogleAdsApiOnly.cs
 shows the code example fully transformed into using the Google Ads API.
