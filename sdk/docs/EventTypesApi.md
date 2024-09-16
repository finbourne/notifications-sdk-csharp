# Finbourne.Notifications.Sdk.Api.EventTypesApi

All URIs are relative to *https://fbn-prd.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEventType**](EventTypesApi.md#geteventtype) | **GET** /api/eventtypes/{eventType} | [EXPERIMENTAL] GetEventType: Gets the specified event type schema. |
| [**ListEventTypes**](EventTypesApi.md#listeventtypes) | **GET** /api/eventtypes | [EXPERIMENTAL] ListEventTypes: Lists all of the available event types. |

<a id="geteventtype"></a>
# **GetEventType**
> EventTypeSchema GetEventType (string eventType)

[EXPERIMENTAL] GetEventType: Gets the specified event type schema.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventTypesApi>();
            var eventType = "eventType_example";  // string | The event type to retrieve schema for.

            try
            {
                // uncomment the below to set overrides at the request level
                // EventTypeSchema result = apiInstance.GetEventType(eventType, opts: opts);

                // [EXPERIMENTAL] GetEventType: Gets the specified event type schema.
                EventTypeSchema result = apiInstance.GetEventType(eventType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventTypesApi.GetEventType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetEventType: Gets the specified event type schema.
    ApiResponse<EventTypeSchema> response = apiInstance.GetEventTypeWithHttpInfo(eventType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventTypesApi.GetEventTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventType** | **string** | The event type to retrieve schema for. |  |

### Return type

[**EventTypeSchema**](EventTypeSchema.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No event type exists with the specified type |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listeventtypes"></a>
# **ListEventTypes**
> ResourceListOfEventTypeSchema ListEventTypes ()

[EXPERIMENTAL] ListEventTypes: Lists all of the available event types.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventTypesApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfEventTypeSchema result = apiInstance.ListEventTypes(opts: opts);

                // [EXPERIMENTAL] ListEventTypes: Lists all of the available event types.
                ResourceListOfEventTypeSchema result = apiInstance.ListEventTypes();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventTypesApi.ListEventTypes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEventTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListEventTypes: Lists all of the available event types.
    ApiResponse<ResourceListOfEventTypeSchema> response = apiInstance.ListEventTypesWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventTypesApi.ListEventTypesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfEventTypeSchema**](ResourceListOfEventTypeSchema.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | No event types found |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

