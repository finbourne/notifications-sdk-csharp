# Finbourne.Notifications.Sdk.Model.ManualEvent
Details of a manually triggered event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Header** | [**ManualEventHeader**](ManualEventHeader.md) |  | 
**Body** | [**ManualEventBody**](ManualEventBody.md) |  | 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

ManualEventHeader header = new ManualEventHeader();
ManualEventBody body = new ManualEventBody();

ManualEvent manualEventInstance = new ManualEvent(
    header: header,
    body: body);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
