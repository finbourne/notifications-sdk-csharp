# Finbourne.Notifications.Sdk.Model.Delivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The identifier of the delivery. | 
**EventId** | **string** | The identifier of the associated event. | 
**SubscriptionId** | [**ResourceId**](ResourceId.md) |  | 
**NotificationId** | **string** | The identifier of the associated notification. | 
**DeliveryChannel** | **string** | The delivery channel of the message. | 
**MessageDetails** | **string** | The Details of the delivery message as JSON string. | 
**Attempts** | [**List&lt;Attempt&gt;**](Attempt.md) | A list of all the delivery attempts made for this message. | 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

Guid id = "id";
string eventId = "eventId";
ResourceId subscriptionId = new ResourceId();
string notificationId = "notificationId";
string deliveryChannel = "deliveryChannel";
string messageDetails = "messageDetails";
List<Attempt> attempts = new List<Attempt>();

Delivery deliveryInstance = new Delivery(
    id: id,
    eventId: eventId,
    subscriptionId: subscriptionId,
    notificationId: notificationId,
    deliveryChannel: deliveryChannel,
    messageDetails: messageDetails,
    attempts: attempts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
