# Finbourne.Notifications.Sdk.Model.AttemptStatus
Status of the delivery attempt.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **string** | Result of the delivery. | 
**DetailedMessage** | **string** | The detailed message from attempting to deliver the message. | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string result = "result";
string detailedMessage = "example detailedMessage";

AttemptStatus attemptStatusInstance = new AttemptStatus(
    result: result,
    detailedMessage: detailedMessage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
