# Finbourne.Notifications.Sdk.Model.UpdateSubscription
The information required to update a subscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the subscription | 
**Description** | **string** | The summary of the services provided by the subscription | [optional] 
**Status** | **string** | The current status of the subscription. Possible values are: Active, Inactive | 
**MatchingPattern** | [**MatchingPattern**](MatchingPattern.md) |  | 
**UseAsAuth** | **string** | Id of user associated with subscription. All events associated with   the subscription will use this user to check entitlements against   the resource to send a notification. Can be null, in which case   we&#39;ll default to that of the user making this request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

