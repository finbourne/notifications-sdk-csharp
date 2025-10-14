# Finbourne.Notifications.Sdk.Model.ManualEventBody
The body of the manual event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subject** | **string** | The subject of the manual event | 
**Message** | **string** | The message of the manual event | 
**JsonMessage** | **Object** | The JSON message of the manual event | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string subject = "subject";
string message = "message";

ManualEventBody manualEventBodyInstance = new ManualEventBody(
    subject: subject,
    message: message,
    jsonMessage: jsonMessage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
