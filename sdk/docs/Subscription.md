# Finbourne.Notifications.Sdk.Model.Subscription
A subscription object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the subscription | 
**Description** | **string** | The summary of the services provided by the subscription | [optional] 
**Status** | **string** | The current status of the subscription | 
**MatchingPattern** | [**MatchingPattern**](MatchingPattern.md) |  | 
**CreatedAt** | **DateTimeOffset** | The time at which the subscription was made | 
**UserIdCreated** | **string** | The user who made the subscription | 
**ModifiedAt** | **DateTimeOffset** | The time at which the subscription was last modified | 
**UserIdModified** | **string** | The user who last modified the subscription | 
**UseAsAuth** | **string** | The user to use as auth for the subscription | 
**Href** | **string** | A URI for retrieving this subscription | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
string status = "status";
MatchingPattern matchingPattern = new MatchingPattern();
string userIdCreated = "userIdCreated";
string userIdModified = "userIdModified";
string useAsAuth = "useAsAuth";
string href = "example href";

Subscription subscriptionInstance = new Subscription(
    id: id,
    displayName: displayName,
    description: description,
    status: status,
    matchingPattern: matchingPattern,
    createdAt: createdAt,
    userIdCreated: userIdCreated,
    modifiedAt: modifiedAt,
    userIdModified: userIdModified,
    useAsAuth: useAsAuth,
    href: href);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
