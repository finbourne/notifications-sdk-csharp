# Finbourne.Notifications.Sdk.Api.NotificationsApi

All URIs are relative to *https://fbn-prd.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNotification**](NotificationsApi.md#createnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications | CreateNotification: Add a Notification to a Subscription. |
| [**DeleteNotification**](NotificationsApi.md#deletenotification) | **DELETE** /api/subscriptions/{scope}/{code}/notifications/{id} | DeleteNotification: Delete a notification for a given subscription. |
| [**GetNotification**](NotificationsApi.md#getnotification) | **GET** /api/subscriptions/{scope}/{code}/notifications/{id} | GetNotification: Get a notification on a subscription. |
| [**ListNotifications**](NotificationsApi.md#listnotifications) | **GET** /api/subscriptions/{scope}/{code}/notifications | ListNotifications: List all notifications on a subscription. |
| [**UpdateNotification**](NotificationsApi.md#updatenotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/{id} | UpdateNotification: Update a Notification for a Subscription |

<a id="createnotification"></a>
# **CreateNotification**
> Notification CreateNotification (string scope, string code, CreateNotificationRequest createNotificationRequest)

CreateNotification: Add a Notification to a Subscription.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""notificationsUrl"": ""https://<your-domain>.lusid.com/notification"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NotificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NotificationsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription
            var createNotificationRequest = new CreateNotificationRequest(); // CreateNotificationRequest | The data to create a notification

            try
            {
                // uncomment the below to set overrides at the request level
                // Notification result = apiInstance.CreateNotification(scope, code, createNotificationRequest, opts: opts);

                // CreateNotification: Add a Notification to a Subscription.
                Notification result = apiInstance.CreateNotification(scope, code, createNotificationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NotificationsApi.CreateNotification: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateNotification: Add a Notification to a Subscription.
    ApiResponse<Notification> response = apiInstance.CreateNotificationWithHttpInfo(scope, code, createNotificationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NotificationsApi.CreateNotificationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |
| **createNotificationRequest** | [**CreateNotificationRequest**](CreateNotificationRequest.md) | The data to create a notification |  |

### Return type

[**Notification**](Notification.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletenotification"></a>
# **DeleteNotification**
> void DeleteNotification (string scope, string code, string id)

DeleteNotification: Delete a notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""notificationsUrl"": ""https://<your-domain>.lusid.com/notification"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NotificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NotificationsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription
            var id = "id_example";  // string | The unique identifier of the notification

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteNotification(scope, code, id, opts: opts);

                // DeleteNotification: Delete a notification for a given subscription.
                apiInstance.DeleteNotification(scope, code, id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NotificationsApi.DeleteNotification: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteNotification: Delete a notification for a given subscription.
    apiInstance.DeleteNotificationWithHttpInfo(scope, code, id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NotificationsApi.DeleteNotificationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |
| **id** | **string** | The unique identifier of the notification |  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getnotification"></a>
# **GetNotification**
> Notification GetNotification (string scope, string code, string id)

GetNotification: Get a notification on a subscription.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""notificationsUrl"": ""https://<your-domain>.lusid.com/notification"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NotificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NotificationsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription
            var id = "id_example";  // string | The unique identifier of the notification

            try
            {
                // uncomment the below to set overrides at the request level
                // Notification result = apiInstance.GetNotification(scope, code, id, opts: opts);

                // GetNotification: Get a notification on a subscription.
                Notification result = apiInstance.GetNotification(scope, code, id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NotificationsApi.GetNotification: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetNotification: Get a notification on a subscription.
    ApiResponse<Notification> response = apiInstance.GetNotificationWithHttpInfo(scope, code, id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NotificationsApi.GetNotificationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |
| **id** | **string** | The unique identifier of the notification |  |

### Return type

[**Notification**](Notification.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listnotifications"></a>
# **ListNotifications**
> ResourceListOfNotification ListNotifications (string scope, string code)

ListNotifications: List all notifications on a subscription.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""notificationsUrl"": ""https://<your-domain>.lusid.com/notification"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NotificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NotificationsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfNotification result = apiInstance.ListNotifications(scope, code, opts: opts);

                // ListNotifications: List all notifications on a subscription.
                ResourceListOfNotification result = apiInstance.ListNotifications(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NotificationsApi.ListNotifications: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNotificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListNotifications: List all notifications on a subscription.
    ApiResponse<ResourceListOfNotification> response = apiInstance.ListNotificationsWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NotificationsApi.ListNotificationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |

### Return type

[**ResourceListOfNotification**](ResourceListOfNotification.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notifications exists with the provided filter(s) |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatenotification"></a>
# **UpdateNotification**
> Notification UpdateNotification (string scope, string code, string id, UpdateNotificationRequest updateNotificationRequest)

UpdateNotification: Update a Notification for a Subscription

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""notificationsUrl"": ""https://<your-domain>.lusid.com/notification"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NotificationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NotificationsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription
            var id = "id_example";  // string | The unique identifier of the notification
            var updateNotificationRequest = new UpdateNotificationRequest(); // UpdateNotificationRequest | The data to update a notification

            try
            {
                // uncomment the below to set overrides at the request level
                // Notification result = apiInstance.UpdateNotification(scope, code, id, updateNotificationRequest, opts: opts);

                // UpdateNotification: Update a Notification for a Subscription
                Notification result = apiInstance.UpdateNotification(scope, code, id, updateNotificationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NotificationsApi.UpdateNotification: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateNotification: Update a Notification for a Subscription
    ApiResponse<Notification> response = apiInstance.UpdateNotificationWithHttpInfo(scope, code, id, updateNotificationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NotificationsApi.UpdateNotificationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |
| **id** | **string** | The unique identifier of the notification |  |
| **updateNotificationRequest** | [**UpdateNotificationRequest**](UpdateNotificationRequest.md) | The data to update a notification |  |

### Return type

[**Notification**](Notification.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

