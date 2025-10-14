# Finbourne.Notifications.Sdk.Model.EventTypeSchema
An EventType object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the event type | [optional] 
**DisplayName** | **string** | Identifier name of the event | [optional] 
**Description** | **string** | The summary of the event | [optional] 
**Application** | **string** | The application associated with the event | [optional] 
**HeaderSchema** | [**List&lt;EventFieldDefinition&gt;**](EventFieldDefinition.md) | The header schema for the event type | [optional] [readonly] 
**BodySchema** | [**List&lt;EventFieldDefinition&gt;**](EventFieldDefinition.md) | The body schema for the event type | [optional] [readonly] 
**Href** | **string** | A URI for retrieving this schema | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string id = "example id";
string displayName = "example displayName";
string description = "example description";
string application = "example application";
List<EventFieldDefinition> headerSchema = new List<EventFieldDefinition>();
List<EventFieldDefinition> bodySchema = new List<EventFieldDefinition>();
string href = "example href";

EventTypeSchema eventTypeSchemaInstance = new EventTypeSchema(
    id: id,
    displayName: displayName,
    description: description,
    application: application,
    headerSchema: headerSchema,
    bodySchema: bodySchema,
    href: href);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
