# WhatsAPI.whatsapi.MiscellaneousApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstancesInstanceKeyMiscProfilePicGet**](MiscellaneousApi.md#instancesinstancekeymiscprofilepicget) | **GET** /instances/{instance_key}/misc/profile-pic | Get profile pic.
[**InstancesInstanceKeyMiscUserInfoPost**](MiscellaneousApi.md#instancesinstancekeymiscuserinfopost) | **POST** /instances/{instance_key}/misc/user-info | Fetches the users info.



## InstancesInstanceKeyMiscProfilePicGet

> APIResponse InstancesInstanceKeyMiscProfilePicGet (string instanceKey, string jid)

Get profile pic.

Returns the profile pic of the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyMiscProfilePicGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MiscellaneousApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var jid = "jid_example";  // string | JID

            try
            {
                // Get profile pic.
                APIResponse result = apiInstance.InstancesInstanceKeyMiscProfilePicGet(instanceKey, jid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.InstancesInstanceKeyMiscProfilePicGet: " + e.Message );
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
 **jid** | **string**| JID | 

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


## InstancesInstanceKeyMiscUserInfoPost

> APIResponse InstancesInstanceKeyMiscUserInfoPost (string instanceKey, UserInfoPayload data)

Fetches the users info.

Gets the user info for the given user ids. This does not checks if user is registered or not

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyMiscUserInfoPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MiscellaneousApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new UserInfoPayload(); // UserInfoPayload | Data

            try
            {
                // Fetches the users info.
                APIResponse result = apiInstance.InstancesInstanceKeyMiscUserInfoPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.InstancesInstanceKeyMiscUserInfoPost: " + e.Message );
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
 **data** | [**UserInfoPayload**](UserInfoPayload.md)| Data | 

### Return type

[**APIResponse**](APIResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: application/json
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

