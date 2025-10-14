# Finbourne.Notifications.Sdk.Model.AzureServiceBusTypeResponse
Holds readonly information about an Azure Service Bus notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | [optional] 
**NamespaceRef** | **string** | Reference to namespace from Configuration Store | [optional] 
**QueueNameRef** | **string** | Reference to queue name from Configuration Store | [optional] 
**Body** | **string** | The body of the Azure service bus Message | [optional] 
**TenantIdRef** | **string** | Reference to tenant id  from Configuration Store | [optional] 
**ClientIdRef** | **string** | Reference to client id from Configuration Store | [optional] 
**ClientSecretRef** | **string** | Reference to client secret from Configuration Store | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string type = "example type";
string namespaceRef = "example namespaceRef";
string queueNameRef = "example queueNameRef";
string body = "example body";
string tenantIdRef = "example tenantIdRef";
string clientIdRef = "example clientIdRef";
string clientSecretRef = "example clientSecretRef";

AzureServiceBusTypeResponse azureServiceBusTypeResponseInstance = new AzureServiceBusTypeResponse(
    type: type,
    namespaceRef: namespaceRef,
    queueNameRef: queueNameRef,
    body: body,
    tenantIdRef: tenantIdRef,
    clientIdRef: clientIdRef,
    clientSecretRef: clientSecretRef);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
