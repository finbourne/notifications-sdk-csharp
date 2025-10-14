# Finbourne.Notifications.Sdk.Model.UpdateSubscription
The information required to update a subscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the subscription | 
**Description** | **string** | The summary of the services provided by the subscription | [optional] 
**Status** | **string** | The current status of the subscription. Possible values are: Active, Inactive | 
**MatchingPattern** | [**MatchingPattern**](MatchingPattern.md) |  | 
**UseAsAuth** | **string** | Id of user associated with subscription. All events associated with  the subscription will use this user to check entitlements against  the resource to send a notification. Can be null, in which case  we&#39;ll default to that of the user making this request | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string status = "status";
MatchingPattern matchingPattern = new MatchingPattern();
string useAsAuth = "example useAsAuth";

UpdateSubscription updateSubscriptionInstance = new UpdateSubscription(
    displayName: displayName,
    description: description,
    status: status,
    matchingPattern: matchingPattern,
    useAsAuth: useAsAuth);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
