# Finbourne.Notifications.Sdk.Model.AzureServiceBusNotificationType
The information required to create or update an Azure Service Bus notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | 
**Namespace** | **string** | Reference to namespace from Configuration Store | 
**QueueName** | **string** | Reference to queue name from Configuration Store | 
**Body** | **string** | The body of the Azure Service Bus Message | 
**TenantId** | **string** | Reference to tenant id from Configuration Store | 
**ClientId** | **string** | Reference to client id from Configuration Store | 
**ClientSecret** | **string** | Reference to client secret from Configuration Store | 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string type = "type";
string namespace = "namespace";
string queueName = "queueName";
string body = "body";
string tenantId = "tenantId";
string clientId = "clientId";
string clientSecret = "clientSecret";

AzureServiceBusNotificationType azureServiceBusNotificationTypeInstance = new AzureServiceBusNotificationType(
    type: type,
    namespace: namespace,
    queueName: queueName,
    body: body,
    tenantId: tenantId,
    clientId: clientId,
    clientSecret: clientSecret);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
