# Finbourne.Notifications.Sdk.Model.UpdateNotificationRequest
The information required to update a notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the notification | 
**Description** | **string** | The summary of the services provided by the notification | [optional] 
**NotificationType** | [**NotificationType**](NotificationType.md) |  | 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
NotificationType notificationType = new NotificationType();

UpdateNotificationRequest updateNotificationRequestInstance = new UpdateNotificationRequest(
    displayName: displayName,
    description: description,
    notificationType: notificationType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
