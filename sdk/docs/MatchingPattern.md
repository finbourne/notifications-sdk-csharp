# Finbourne.Notifications.Sdk.Model.MatchingPattern
A matching pattern object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The type of event to subscribe to. The list of available event types can be discovered by calling the ‘List available EventTypes’ API endpoint. | 
**Filter** | **string** | A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string eventType = "eventType";
string filter = "example filter";

MatchingPattern matchingPatternInstance = new MatchingPattern(
    eventType: eventType,
    filter: filter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
