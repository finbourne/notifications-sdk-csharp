# Finbourne.Notifications.Sdk.Api.DeliveriesApi

All URIs are relative to *https://fbn-prd.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListDeliveries**](DeliveriesApi.md#listdeliveries) | **GET** /api/deliveries | [EXPERIMENTAL] ListDeliveries: List Deliveries |

<a id="listdeliveries"></a>
# **ListDeliveries**
> ResourceListOfDelivery ListDeliveries (string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListDeliveries: List Deliveries

Currently only returns deliveries with failed attempts.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DeliveriesApi>();
            var page = "page_example";  // string? | The pagination token to use to continue listing delivery attempts. This value is returned from the previous call. When this field is supplied the filter field should not be supplied. (optional) 
            var limit = 56;  // int? | The maximum number of delivery attempts to retrieve. Defaults to 200 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914.  By default, we set this filter to only query for the last week's worth of Deliveries, however if a filter is explicitly set, this will be overriden.  An example filter to override the attempt time date might be 'AttemptTime gt 2023-08-25' for example (optional) 

            try
            {
                // [EXPERIMENTAL] ListDeliveries: List Deliveries
                ResourceListOfDelivery result = apiInstance.ListDeliveries(page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DeliveriesApi.ListDeliveries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDeliveriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListDeliveries: List Deliveries
    ApiResponse<ResourceListOfDelivery> response = apiInstance.ListDeliveriesWithHttpInfo(page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DeliveriesApi.ListDeliveriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **string?** | The pagination token to use to continue listing delivery attempts. This value is returned from the previous call. When this field is supplied the filter field should not be supplied. | [optional]  |
| **limit** | **int?** | The maximum number of delivery attempts to retrieve. Defaults to 200 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914.  By default, we set this filter to only query for the last week&#39;s worth of Deliveries, however if a filter is explicitly set, this will be overriden.  An example filter to override the attempt time date might be &#39;AttemptTime gt 2023-08-25&#39; for example | [optional]  |

### Return type

[**ResourceListOfDelivery**](ResourceListOfDelivery.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No deliveries exists with the provided filter(s) |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

