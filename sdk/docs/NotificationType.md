# Finbourne.Notifications.Sdk.Model.NotificationType
Holds information about a Finbourne.Notifications.WebApi.Dtos.Notifications.Notification that is being created

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | 
**ApiKeyRef** | **string** | Reference to API key from Configuration Store | 
**ApiSecretRef** | **string** | Reference to API secret from Configuration Store | 
**Body** | **string** | The body of the SMS | 
**QueueUrlRef** | **string** | Reference to queue url from Configuration Store | 
**Namespace** | **string** | Reference to namespace from Configuration Store | 
**QueueName** | **string** | Reference to queue name from Configuration Store | 
**TenantId** | **string** | Reference to tenant id from Configuration Store | 
**ClientId** | **string** | Reference to client id from Configuration Store | 
**ClientSecret** | **string** | Reference to client secret from Configuration Store | 
**Subject** | **string** | The subject of the email | 
**PlainTextBody** | **string** | The plain text body of the email | 
**HtmlBody** | **string** | The HTML body of the email (if any) | [optional] 
**EmailAddressTo** | **List&lt;string&gt;** | &#39;To&#39; recipients of the email | 
**EmailAddressCc** | **List&lt;string&gt;** | &#39;Cc&#39; recipients of the email | [optional] 
**EmailAddressBcc** | **List&lt;string&gt;** | &#39;Bcc&#39; recipients of the email | [optional] 
**Recipients** | **List&lt;string&gt;** | The phone numbers to which the SMS will be sent to (E.164 format) | 
**HttpMethod** | **string** | The HTTP method such as GET, POST, etc. to use on the request | 
**Url** | **string** | The URL to send the request to | 
**AuthenticationType** | **string** | The type of authentication to use on the request, can be one of the following values:  - Lusid -  Internal LUSID call  - BasicAuth - User specified Username and password  - BearerToken - Authorization header with Bearer scheme and user specified key  - None - No Authorization required on the webhook call | 
**AuthenticationConfigurationItemPaths** | **Dictionary&lt;string, string&gt;** | The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;  - None - None required                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      } | [optional] 
**ContentType** | **string** | The type of the content e.g. Json | 
**Content** | **Object** | The content of the request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

