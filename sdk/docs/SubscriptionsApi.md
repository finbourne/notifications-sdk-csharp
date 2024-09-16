# Finbourne.Notifications.Sdk.Api.SubscriptionsApi

All URIs are relative to *https://fbn-prd.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSubscription**](SubscriptionsApi.md#createsubscription) | **POST** /api/subscriptions | [EXPERIMENTAL] CreateSubscription: Create a new subscription. |
| [**DeleteSubscription**](SubscriptionsApi.md#deletesubscription) | **DELETE** /api/subscriptions/{scope}/{code} | [EXPERIMENTAL] DeleteSubscription: Delete a subscription. |
| [**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /api/subscriptions/{scope}/{code} | [EXPERIMENTAL] GetSubscription: Get a subscription. |
| [**ListSubscriptions**](SubscriptionsApi.md#listsubscriptions) | **GET** /api/subscriptions | [EXPERIMENTAL] ListSubscriptions: List subscriptions. |
| [**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PUT** /api/subscriptions/{scope}/{code} | [EXPERIMENTAL] UpdateSubscription: Update an existing subscription. |

<a id="createsubscription"></a>
# **CreateSubscription**
> Subscription CreateSubscription (CreateSubscription createSubscription)

[EXPERIMENTAL] CreateSubscription: Create a new subscription.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var createSubscription = new CreateSubscription(); // CreateSubscription | The data to create a subscription

            try
            {
                // uncomment the below to set overrides at the request level
                // Subscription result = apiInstance.CreateSubscription(createSubscription, opts: opts);

                // [EXPERIMENTAL] CreateSubscription: Create a new subscription.
                Subscription result = apiInstance.CreateSubscription(createSubscription);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.CreateSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateSubscription: Create a new subscription.
    ApiResponse<Subscription> response = apiInstance.CreateSubscriptionWithHttpInfo(createSubscription);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.CreateSubscriptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSubscription** | [**CreateSubscription**](CreateSubscription.md) | The data to create a subscription |  |

### Return type

[**Subscription**](Subscription.md)

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

<a id="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string scope, string code)

[EXPERIMENTAL] DeleteSubscription: Delete a subscription.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteSubscription(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteSubscription: Delete a subscription.
                apiInstance.DeleteSubscription(scope, code);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.DeleteSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteSubscription: Delete a subscription.
    apiInstance.DeleteSubscriptionWithHttpInfo(scope, code);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.DeleteSubscriptionWithHttpInfo: " + e.Message);
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

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No subscription exists in current scope |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getsubscription"></a>
# **GetSubscription**
> Subscription GetSubscription (string scope, string code)

[EXPERIMENTAL] GetSubscription: Get a subscription.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription

            try
            {
                // uncomment the below to set overrides at the request level
                // Subscription result = apiInstance.GetSubscription(scope, code, opts: opts);

                // [EXPERIMENTAL] GetSubscription: Get a subscription.
                Subscription result = apiInstance.GetSubscription(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.GetSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetSubscription: Get a subscription.
    ApiResponse<Subscription> response = apiInstance.GetSubscriptionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.GetSubscriptionWithHttpInfo: " + e.Message);
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

[**Subscription**](Subscription.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No subscription exists in current scope |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listsubscriptions"></a>
# **ListSubscriptions**
> ResourceListOfSubscription ListSubscriptions (string? filter = null, string? sortBy = null, string? page = null, int? limit = null)

[EXPERIMENTAL] ListSubscriptions: List subscriptions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about <a href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</a>. (optional) 
            var sortBy = "sortBy_example";  // string? | Fields to order the result set. Read more about <a href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</a> (optional) 
            var page = "page_example";  // string? | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied the filter  field should not be supplied. (optional) 
            var limit = 56;  // int? | The maximum number of subscriptions to retrieve. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfSubscription result = apiInstance.ListSubscriptions(filter, sortBy, page, limit, opts: opts);

                // [EXPERIMENTAL] ListSubscriptions: List subscriptions.
                ResourceListOfSubscription result = apiInstance.ListSubscriptions(filter, sortBy, page, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.ListSubscriptions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListSubscriptions: List subscriptions.
    ApiResponse<ResourceListOfSubscription> response = apiInstance.ListSubscriptionsWithHttpInfo(filter, sortBy, page, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.ListSubscriptionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Expression to filter the result set. Read more about &lt;a href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/a&gt;. | [optional]  |
| **sortBy** | **string?** | Fields to order the result set. Read more about &lt;a href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/a&gt; | [optional]  |
| **page** | **string?** | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied the filter  field should not be supplied. | [optional]  |
| **limit** | **int?** | The maximum number of subscriptions to retrieve. | [optional]  |

### Return type

[**ResourceListOfSubscription**](ResourceListOfSubscription.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatesubscription"></a>
# **UpdateSubscription**
> Subscription UpdateSubscription (string scope, string code, UpdateSubscription updateSubscription)

[EXPERIMENTAL] UpdateSubscription: Update an existing subscription.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription
            var updateSubscription = new UpdateSubscription(); // UpdateSubscription | The data to update a subscription

            try
            {
                // uncomment the below to set overrides at the request level
                // Subscription result = apiInstance.UpdateSubscription(scope, code, updateSubscription, opts: opts);

                // [EXPERIMENTAL] UpdateSubscription: Update an existing subscription.
                Subscription result = apiInstance.UpdateSubscription(scope, code, updateSubscription);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateSubscription: Update an existing subscription.
    ApiResponse<Subscription> response = apiInstance.UpdateSubscriptionWithHttpInfo(scope, code, updateSubscription);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.UpdateSubscriptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |
| **updateSubscription** | [**UpdateSubscription**](UpdateSubscription.md) | The data to update a subscription |  |

### Return type

[**Subscription**](Subscription.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No subscription exists in current scope |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

