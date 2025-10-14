# Finbourne.Notifications.Sdk.Model.ManualEventHeader
The header of the manual event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The event type of the manual event | [optional] [readonly] 
**Timestamp** | **DateTimeOffset** | The timestamp of the manual event | [optional] 
**UserId** | **string** | The user ID of the manual event | [optional] 
**RequestId** | **string** | The request ID of the manual event | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string eventType = "example eventType";
string userId = "example userId";
string requestId = "example requestId";

ManualEventHeader manualEventHeaderInstance = new ManualEventHeader(
    eventType: eventType,
    timestamp: timestamp,
    userId: userId,
    requestId: requestId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
