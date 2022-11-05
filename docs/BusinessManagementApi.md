# WhatsAPI.whatsapi.BusinessManagementApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstancesInstanceKeyBusinessCatalogGet**](BusinessManagementApi.md#instancesinstancekeybusinesscatalogget) | **GET** /instances/{instance_key}/business/catalog | Fetches the catlog.



## InstancesInstanceKeyBusinessCatalogGet

> APIResponse InstancesInstanceKeyBusinessCatalogGet (string instanceKey)

Fetches the catlog.

Gets list of all products registered by you.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyBusinessCatalogGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key

            try
            {
                // Fetches the catlog.
                APIResponse result = apiInstance.InstancesInstanceKeyBusinessCatalogGet(instanceKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BusinessManagementApi.InstancesInstanceKeyBusinessCatalogGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceKey** | **string**| Instance key | 

### Return type

[**APIResponse**](APIResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Instance not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

