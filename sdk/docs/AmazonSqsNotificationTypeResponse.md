# Finbourne.Notifications.Sdk.Model.AmazonSqsNotificationTypeResponse
Holds readonly information about an AWS SQS notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | [optional] 
**ApiKeyRef** | **string** | Reference to API key from Configuration Store | [optional] 
**ApiSecretRef** | **string** | Reference to API secret from Configuration Store | [optional] 
**Body** | **string** | The body of the Amazon Queue Message | [optional] 
**QueueUrlRef** | **string** | Reference to queue url from Configuration Store | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string type = "example type";
string apiKeyRef = "example apiKeyRef";
string apiSecretRef = "example apiSecretRef";
string body = "example body";
string queueUrlRef = "example queueUrlRef";

AmazonSqsNotificationTypeResponse amazonSqsNotificationTypeResponseInstance = new AmazonSqsNotificationTypeResponse(
    type: type,
    apiKeyRef: apiKeyRef,
    apiSecretRef: apiSecretRef,
    body: body,
    queueUrlRef: queueUrlRef);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
