# Finbourne.Notifications.Sdk.Api.ManualEventApi

All URIs are relative to *https://fbn-prd.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TriggerManualEvent**](ManualEventApi.md#triggermanualevent) | **POST** /api/manualevent | [EXPERIMENTAL] TriggerManualEvent: Trigger a manual event. |

<a id="triggermanualevent"></a>
# **TriggerManualEvent**
> ManualEvent TriggerManualEvent (ManualEventRequest manualEventRequest)

[EXPERIMENTAL] TriggerManualEvent: Trigger a manual event.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ManualEventApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ManualEventApi>();
            var manualEventRequest = new ManualEventRequest(); // ManualEventRequest | The data required to trigger a manual event.

            try
            {
                // uncomment the below to set overrides at the request level
                // ManualEvent result = apiInstance.TriggerManualEvent(manualEventRequest, opts: opts);

                // [EXPERIMENTAL] TriggerManualEvent: Trigger a manual event.
                ManualEvent result = apiInstance.TriggerManualEvent(manualEventRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ManualEventApi.TriggerManualEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the TriggerManualEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] TriggerManualEvent: Trigger a manual event.
    ApiResponse<ManualEvent> response = apiInstance.TriggerManualEventWithHttpInfo(manualEventRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ManualEventApi.TriggerManualEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manualEventRequest** | [**ManualEventRequest**](ManualEventRequest.md) | The data required to trigger a manual event. |  |

### Return type

[**ManualEvent**](ManualEvent.md)

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

