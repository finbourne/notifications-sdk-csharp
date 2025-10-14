# Finbourne.Notifications.Sdk.Model.NotificationStatus
The status object of a notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **string** | The status of the notification | [optional] 
**LastUpdated** | **DateTimeOffset** | The time at which the notification status was last updated | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string result = "example result";

NotificationStatus notificationStatusInstance = new NotificationStatus(
    result: result,
    lastUpdated: lastUpdated);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
