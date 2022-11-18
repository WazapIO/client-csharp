# WhatsAPI.whatsapi.MiscellaneousApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadMedia**](MiscellaneousApi.md#downloadmedia) | **POST** /instances/{instance_key}/misc/download | Download media
[**GetProfilePic**](MiscellaneousApi.md#getprofilepic) | **GET** /instances/{instance_key}/misc/profile-pic | Get profile pic.
[**GetUsersInfo**](MiscellaneousApi.md#getusersinfo) | **POST** /instances/{instance_key}/misc/user-info | Fetches the users info.
[**SetChatPresence**](MiscellaneousApi.md#setchatpresence) | **POST** /instances/{instance_key}/misc/chat-presence | Set chat presence
[**UpdateProfilePic**](MiscellaneousApi.md#updateprofilepic) | **PUT** /instances/{instance_key}/misc/profile-pic | Update profile picture



## DownloadMedia

> APIResponse DownloadMedia (string instanceKey, string fileType, FileUpload data, string responseType = null)

Download media

Downloads the media from the given media keys.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class DownloadMediaExample
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
            var fileType = "image";  // string | File type
            var data = new FileUpload(); // FileUpload | Media data
            var responseType = "responseType_example";  // string | Response type (file, base64) (optional) 

            try
            {
                // Download media
                APIResponse result = apiInstance.DownloadMedia(instanceKey, fileType, data, responseType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.DownloadMedia: " + e.Message );
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
 **fileType** | **string**| File type | 
 **data** | [**FileUpload**](FileUpload.md)| Media data | 
 **responseType** | **string**| Response type (file, base64) | [optional] 

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


## GetProfilePic

> APIResponse GetProfilePic (string instanceKey, string jid)

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
    public class GetProfilePicExample
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
                APIResponse result = apiInstance.GetProfilePic(instanceKey, jid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetProfilePic: " + e.Message );
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


## GetUsersInfo

> APIResponse GetUsersInfo (string instanceKey, UserInfoPayload data)

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
    public class GetUsersInfoExample
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
                APIResponse result = apiInstance.GetUsersInfo(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetUsersInfo: " + e.Message );
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


## SetChatPresence

> APIResponse SetChatPresence (string instanceKey, string jid, string presence)

Set chat presence

Sets the presence of the given chat. (Typing, Recording, Paused) Options: typing, recording, paused

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class SetChatPresenceExample
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
            var presence = "presence_example";  // string | Presence

            try
            {
                // Set chat presence
                APIResponse result = apiInstance.SetChatPresence(instanceKey, jid, presence);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.SetChatPresence: " + e.Message );
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
 **presence** | **string**| Presence | 

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


## UpdateProfilePic

> APIResponse UpdateProfilePic (string instanceKey, UpdateProfilePicRequest updateProfilePicRequest)

Update profile picture

Changes the profile pic of the current logged in user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class UpdateProfilePicExample
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
            var updateProfilePicRequest = new UpdateProfilePicRequest(); // UpdateProfilePicRequest | 

            try
            {
                // Update profile picture
                APIResponse result = apiInstance.UpdateProfilePic(instanceKey, updateProfilePicRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.UpdateProfilePic: " + e.Message );
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
 **updateProfilePicRequest** | [**UpdateProfilePicRequest**](UpdateProfilePicRequest.md)|  | 

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

