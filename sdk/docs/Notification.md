# Finbourne.Notifications.Sdk.Model.Notification
A notification object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotificationId** | **string** | The identifier of the notification | 
**DisplayName** | **string** | The name of the notification | 
**Description** | **string** | The summary of the services provided by the notification | [optional] 
**NotificationType** | [**NotificationTypeResponse**](NotificationTypeResponse.md) |  | 
**CreatedAt** | **DateTimeOffset** | The time at which the subscription was made | 
**UserIdCreated** | **string** | The user who made the subscription | 
**ModifiedAt** | **DateTimeOffset** | The time at which the subscription was last modified | 
**UserIdModified** | **string** | The user who last modified the subscription | 
**Href** | **string** | A URI for retrieving this notification | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string notificationId = "notificationId";
string displayName = "displayName";
string description = "example description";
NotificationTypeResponse notificationType = new NotificationTypeResponse();
string userIdCreated = "userIdCreated";
string userIdModified = "userIdModified";
string href = "example href";

Notification notificationInstance = new Notification(
    notificationId: notificationId,
    displayName: displayName,
    description: description,
    notificationType: notificationType,
    createdAt: createdAt,
    userIdCreated: userIdCreated,
    modifiedAt: modifiedAt,
    userIdModified: userIdModified,
    href: href);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
