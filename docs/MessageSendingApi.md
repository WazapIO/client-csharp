# com.whatsapi.Api.MessageSendingApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstancesInstanceKeyBusinessCatalogGet**](MessageSendingApi.md#instancesinstancekeybusinesscatalogget) | **GET** /instances/{instance_key}/business/catalog | Fetches the catlog.
[**InstancesInstanceKeySendAudioPost**](MessageSendingApi.md#instancesinstancekeysendaudiopost) | **POST** /instances/{instance_key}/send/audio | Send raw audio.
[**InstancesInstanceKeySendButtonMediaPost**](MessageSendingApi.md#instancesinstancekeysendbuttonmediapost) | **POST** /instances/{instance_key}/send/button-media | Send a button message with a media header.
[**InstancesInstanceKeySendButtonsPost**](MessageSendingApi.md#instancesinstancekeysendbuttonspost) | **POST** /instances/{instance_key}/send/buttons | Send a button message.
[**InstancesInstanceKeySendContactPost**](MessageSendingApi.md#instancesinstancekeysendcontactpost) | **POST** /instances/{instance_key}/send/contact | Send a contact message.
[**InstancesInstanceKeySendDocumentPost**](MessageSendingApi.md#instancesinstancekeysenddocumentpost) | **POST** /instances/{instance_key}/send/document | Send raw document.
[**InstancesInstanceKeySendImagePost**](MessageSendingApi.md#instancesinstancekeysendimagepost) | **POST** /instances/{instance_key}/send/image | Send raw image.
[**InstancesInstanceKeySendListPost**](MessageSendingApi.md#instancesinstancekeysendlistpost) | **POST** /instances/{instance_key}/send/list | Send a List message.
[**InstancesInstanceKeySendLocationPost**](MessageSendingApi.md#instancesinstancekeysendlocationpost) | **POST** /instances/{instance_key}/send/location | Send a location message.
[**InstancesInstanceKeySendMediaPost**](MessageSendingApi.md#instancesinstancekeysendmediapost) | **POST** /instances/{instance_key}/send/media | Send a media message.
[**InstancesInstanceKeySendPollPost**](MessageSendingApi.md#instancesinstancekeysendpollpost) | **POST** /instances/{instance_key}/send/poll | Send a Poll message with media.
[**InstancesInstanceKeySendTemplateMediaPost**](MessageSendingApi.md#instancesinstancekeysendtemplatemediapost) | **POST** /instances/{instance_key}/send/template-media | Send a template message with media.
[**InstancesInstanceKeySendTemplatePost**](MessageSendingApi.md#instancesinstancekeysendtemplatepost) | **POST** /instances/{instance_key}/send/template | Send a template message.
[**InstancesInstanceKeySendTextPost**](MessageSendingApi.md#instancesinstancekeysendtextpost) | **POST** /instances/{instance_key}/send/text | Send a text message.
[**InstancesInstanceKeySendUploadPost**](MessageSendingApi.md#instancesinstancekeysenduploadpost) | **POST** /instances/{instance_key}/send/upload | Upload media.
[**InstancesInstanceKeySendVideoPost**](MessageSendingApi.md#instancesinstancekeysendvideopost) | **POST** /instances/{instance_key}/send/video | Send raw video.



## InstancesInstanceKeyBusinessCatalogGet

> MainAPIResponse InstancesInstanceKeyBusinessCatalogGet (string instanceKey)

Fetches the catlog.

Gets list of all products registered by you.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

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

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key

            try
            {
                // Fetches the catlog.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyBusinessCatalogGet(instanceKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeyBusinessCatalogGet: " + e.Message );
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

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendAudioPost

> MainAPIResponse InstancesInstanceKeySendAudioPost (string instanceKey, string to, InstancesInstanceKeySendAudioPostRequest instancesInstanceKeySendAudioPostRequest, string caption = null)

Send raw audio.

Sends a audio message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendAudioPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var to = "to_example";  // string | The recipient's number
            var instancesInstanceKeySendAudioPostRequest = new InstancesInstanceKeySendAudioPostRequest(); // InstancesInstanceKeySendAudioPostRequest | 
            var caption = "caption_example";  // string | Attached caption (optional) 

            try
            {
                // Send raw audio.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendAudioPost(instanceKey, to, instancesInstanceKeySendAudioPostRequest, caption);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendAudioPost: " + e.Message );
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
 **to** | **string**| The recipient&#39;s number | 
 **instancesInstanceKeySendAudioPostRequest** | [**InstancesInstanceKeySendAudioPostRequest**](InstancesInstanceKeySendAudioPostRequest.md)|  | 
 **caption** | **string**| Attached caption | [optional] 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendButtonMediaPost

> MainAPIResponse InstancesInstanceKeySendButtonMediaPost (string instanceKey, StructsButtonMessageWithMediaPayload data)

Send a button message with a media header.

Sends an interactive button message to the given user. This message also has media header with it. Make sure that all the button ids are unique

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendButtonMediaPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsButtonMessageWithMediaPayload(); // StructsButtonMessageWithMediaPayload | Message data

            try
            {
                // Send a button message with a media header.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendButtonMediaPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendButtonMediaPost: " + e.Message );
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
 **data** | [**StructsButtonMessageWithMediaPayload**](StructsButtonMessageWithMediaPayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendButtonsPost

> MainAPIResponse InstancesInstanceKeySendButtonsPost (string instanceKey, StructsButtonMessagePayload data)

Send a button message.

Sends an interactive button message to the given user. Make sure that all the button ids are unique

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendButtonsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsButtonMessagePayload(); // StructsButtonMessagePayload | Message data

            try
            {
                // Send a button message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendButtonsPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendButtonsPost: " + e.Message );
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
 **data** | [**StructsButtonMessagePayload**](StructsButtonMessagePayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendContactPost

> MainAPIResponse InstancesInstanceKeySendContactPost (string instanceKey, StructsContactMessagePayload data)

Send a contact message.

Sends a contact (vcard) message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendContactPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsContactMessagePayload(); // StructsContactMessagePayload | Message data

            try
            {
                // Send a contact message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendContactPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendContactPost: " + e.Message );
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
 **data** | [**StructsContactMessagePayload**](StructsContactMessagePayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendDocumentPost

> MainAPIResponse InstancesInstanceKeySendDocumentPost (string instanceKey, string to, InstancesInstanceKeySendDocumentPostRequest instancesInstanceKeySendDocumentPostRequest, string caption = null)

Send raw document.

Sends a document message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendDocumentPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var to = "to_example";  // string | The recipient's number
            var instancesInstanceKeySendDocumentPostRequest = new InstancesInstanceKeySendDocumentPostRequest(); // InstancesInstanceKeySendDocumentPostRequest | 
            var caption = "caption_example";  // string | Attached caption (optional) 

            try
            {
                // Send raw document.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendDocumentPost(instanceKey, to, instancesInstanceKeySendDocumentPostRequest, caption);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendDocumentPost: " + e.Message );
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
 **to** | **string**| The recipient&#39;s number | 
 **instancesInstanceKeySendDocumentPostRequest** | [**InstancesInstanceKeySendDocumentPostRequest**](InstancesInstanceKeySendDocumentPostRequest.md)|  | 
 **caption** | **string**| Attached caption | [optional] 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendImagePost

> MainAPIResponse InstancesInstanceKeySendImagePost (string instanceKey, string to, InstancesInstanceKeySendImagePostRequest instancesInstanceKeySendImagePostRequest, string caption = null)

Send raw image.

Sends a image message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendImagePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var to = "to_example";  // string | The recipient's number
            var instancesInstanceKeySendImagePostRequest = new InstancesInstanceKeySendImagePostRequest(); // InstancesInstanceKeySendImagePostRequest | 
            var caption = "caption_example";  // string | Attached caption (optional) 

            try
            {
                // Send raw image.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendImagePost(instanceKey, to, instancesInstanceKeySendImagePostRequest, caption);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendImagePost: " + e.Message );
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
 **to** | **string**| The recipient&#39;s number | 
 **instancesInstanceKeySendImagePostRequest** | [**InstancesInstanceKeySendImagePostRequest**](InstancesInstanceKeySendImagePostRequest.md)|  | 
 **caption** | **string**| Attached caption | [optional] 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendListPost

> MainAPIResponse InstancesInstanceKeySendListPost (string instanceKey, StructsListMessagePayload data)

Send a List message.

Sends an interactive List message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendListPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsListMessagePayload(); // StructsListMessagePayload | Message data

            try
            {
                // Send a List message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendListPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendListPost: " + e.Message );
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
 **data** | [**StructsListMessagePayload**](StructsListMessagePayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendLocationPost

> MainAPIResponse InstancesInstanceKeySendLocationPost (string instanceKey, StructsLocationMessagePayload data)

Send a location message.

Sends a location message to the given user. This is static location and does not update Note: The Address and Url fields are optional

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendLocationPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsLocationMessagePayload(); // StructsLocationMessagePayload | Message data

            try
            {
                // Send a location message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendLocationPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendLocationPost: " + e.Message );
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
 **data** | [**StructsLocationMessagePayload**](StructsLocationMessagePayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendMediaPost

> MainAPIResponse InstancesInstanceKeySendMediaPost (string instanceKey, StructsSendMediaPayload data)

Send a media message.

Sends a media message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendMediaPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsSendMediaPayload(); // StructsSendMediaPayload | Message data

            try
            {
                // Send a media message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendMediaPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendMediaPost: " + e.Message );
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
 **data** | [**StructsSendMediaPayload**](StructsSendMediaPayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendPollPost

> MainAPIResponse InstancesInstanceKeySendPollPost (string instanceKey, StructsPollMessagePayload data)

Send a Poll message with media.

Sends an interactive poll message with a media header to the given user. The poll message is a new feature that is currently in beta.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendPollPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsPollMessagePayload(); // StructsPollMessagePayload | Message data

            try
            {
                // Send a Poll message with media.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendPollPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendPollPost: " + e.Message );
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
 **data** | [**StructsPollMessagePayload**](StructsPollMessagePayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendTemplateMediaPost

> MainAPIResponse InstancesInstanceKeySendTemplateMediaPost (string instanceKey, StructsTemplateButtonWithMediaPayload data)

Send a template message with media.

Sends an interactive template message with a media header to the given user. Note: The valid button types are \"replyButton\", \"urlButton\", \"callButton\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendTemplateMediaPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsTemplateButtonWithMediaPayload(); // StructsTemplateButtonWithMediaPayload | Message data

            try
            {
                // Send a template message with media.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendTemplateMediaPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendTemplateMediaPost: " + e.Message );
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
 **data** | [**StructsTemplateButtonWithMediaPayload**](StructsTemplateButtonWithMediaPayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendTemplatePost

> MainAPIResponse InstancesInstanceKeySendTemplatePost (string instanceKey, StructsTemplateButtonPayload data)

Send a template message.

Sends an interactive template message to the given user. Note: The valid button types are \"replyButton\", \"urlButton\", \"callButton\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendTemplatePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsTemplateButtonPayload(); // StructsTemplateButtonPayload | Message data

            try
            {
                // Send a template message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendTemplatePost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendTemplatePost: " + e.Message );
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
 **data** | [**StructsTemplateButtonPayload**](StructsTemplateButtonPayload.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendTextPost

> MainAPIResponse InstancesInstanceKeySendTextPost (string instanceKey, StructsTextMessage data)

Send a text message.

Sends a text message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendTextPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new StructsTextMessage(); // StructsTextMessage | Message data

            try
            {
                // Send a text message.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendTextPost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendTextPost: " + e.Message );
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
 **data** | [**StructsTextMessage**](StructsTextMessage.md)| Message data | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendUploadPost

> MainAPIResponse InstancesInstanceKeySendUploadPost (string instanceKey, string type, InstancesInstanceKeySendUploadPostRequest instancesInstanceKeySendUploadPostRequest)

Upload media.

Uploads media to WhatsApp servers and returns the media keys. Store the returned media keys, as you will need them to send media messages

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendUploadPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var type = "image";  // string | Media type
            var instancesInstanceKeySendUploadPostRequest = new InstancesInstanceKeySendUploadPostRequest(); // InstancesInstanceKeySendUploadPostRequest | 

            try
            {
                // Upload media.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendUploadPost(instanceKey, type, instancesInstanceKeySendUploadPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendUploadPost: " + e.Message );
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
 **type** | **string**| Media type | 
 **instancesInstanceKeySendUploadPostRequest** | [**InstancesInstanceKeySendUploadPostRequest**](InstancesInstanceKeySendUploadPostRequest.md)|  | 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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


## InstancesInstanceKeySendVideoPost

> MainAPIResponse InstancesInstanceKeySendVideoPost (string instanceKey, string to, InstancesInstanceKeySendVideoPostRequest instancesInstanceKeySendVideoPostRequest, string caption = null)

Send raw video.

Sends a video message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.whatsapi.Api;
using com.whatsapi.Client;
using com.whatsapi.Model;

namespace Example
{
    public class InstancesInstanceKeySendVideoPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageSendingApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var to = "to_example";  // string | The recipient's number
            var instancesInstanceKeySendVideoPostRequest = new InstancesInstanceKeySendVideoPostRequest(); // InstancesInstanceKeySendVideoPostRequest | 
            var caption = "caption_example";  // string | Attached caption (optional) 

            try
            {
                // Send raw video.
                MainAPIResponse result = apiInstance.InstancesInstanceKeySendVideoPost(instanceKey, to, instancesInstanceKeySendVideoPostRequest, caption);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageSendingApi.InstancesInstanceKeySendVideoPost: " + e.Message );
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
 **to** | **string**| The recipient&#39;s number | 
 **instancesInstanceKeySendVideoPostRequest** | [**InstancesInstanceKeySendVideoPostRequest**](InstancesInstanceKeySendVideoPostRequest.md)|  | 
 **caption** | **string**| Attached caption | [optional] 

### Return type

[**MainAPIResponse**](MainAPIResponse.md)

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

