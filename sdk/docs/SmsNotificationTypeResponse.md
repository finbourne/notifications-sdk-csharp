# Finbourne.Notifications.Sdk.Model.SmsNotificationTypeResponse
Holds readonly information about an SMS notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | [optional] 
**Body** | **string** | The body of the SMS | [optional] 
**Recipients** | **List&lt;string&gt;** | The phone numbers to which the SMS will be sent to (E.164 format) | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string type = "example type";
string body = "example body";
List<string> recipients = new List<string>();

SmsNotificationTypeResponse smsNotificationTypeResponseInstance = new SmsNotificationTypeResponse(
    type: type,
    body: body,
    recipients: recipients);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
