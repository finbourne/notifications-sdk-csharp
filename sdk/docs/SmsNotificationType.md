# Finbourne.Notifications.Sdk.Model.SmsNotificationType
The information required to create or update an SMS notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | 
**Body** | **string** | The body of the SMS | 
**Recipients** | **List&lt;string&gt;** | The phone numbers to which the SMS will be sent to (E.164 format) | 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string type = "type";
string body = "body";
List<string> recipients = new List<string>();

SmsNotificationType smsNotificationTypeInstance = new SmsNotificationType(
    type: type,
    body: body,
    recipients: recipients);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
