# WhatsAPI.whatsapi.MessageSendingApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstancesInstanceKeySendAudioPost**](MessageSendingApi.md#instancesinstancekeysendaudiopost) | **POST** /instances/{instance_key}/send/audio | Send raw audio.
[**InstancesInstanceKeySendButtonMediaPost**](MessageSendingApi.md#instancesinstancekeysendbuttonmediapost) | **POST** /instances/{instance_key}/send/button-media | Send a button message with a media header.
[**InstancesInstanceKeySendButtonsPost**](MessageSendingApi.md#instancesinstancekeysendbuttonspost) | **POST** /instances/{instance_key}/send/buttons | Send a button message.
[**InstancesInstanceKeySendContactPost**](MessageSendingApi.md#instancesinstancekeysendcontactpost) | **POST** /instances/{instance_key}/send/contact | Send a contact message.
[**InstancesInstanceKeySendDocumentPost**](MessageSendingApi.md#instancesinstancekeysenddocumentpost) | **POST** /instances/{instance_key}/send/document | Send raw document.
[**InstancesInstanceKeySendImagePost**](MessageSendingApi.md#instancesinstancekeysendimagepost) | **POST** /instances/{instance_key}/send/image | Send raw image.
[**InstancesInstanceKeySendListPost**](MessageSendingApi.md#instancesinstancekeysendlistpost) | **POST** /instances/{instance_key}/send/list | Send a List message.
[**InstancesInstanceKeySendLocationPost**](MessageSendingApi.md#instancesinstancekeysendlocationpost) | **POST** /instances/{instance_key}/send/location | Send a location message.
[**InstancesInstanceKeySendMediaPost**](MessageSendingApi.md#instancesinstancekeysendmediapost) | **POST** /instances/{instance_key}/send/media | Send a media message.
[**InstancesInstanceKeySendPollPost**](MessageSendingApi.md#instancesinstancekeysendpollpost) | **POST** /instances/{instance_key}/send/poll | Send a Poll message.
[**InstancesInstanceKeySendTemplateMediaPost**](MessageSendingApi.md#instancesinstancekeysendtemplatemediapost) | **POST** /instances/{instance_key}/send/template-media | Send a template message with media.
[**InstancesInstanceKeySendTemplatePost**](MessageSendingApi.md#instancesinstancekeysendtemplatepost) | **POST** /instances/{instance_key}/send/template | Send a template message.
[**InstancesInstanceKeySendTextPost**](MessageSendingApi.md#instancesinstancekeysendtextpost) | **POST** /instances/{instance_key}/send/text | Send a text message.
[**InstancesInstanceKeySendUploadPost**](MessageSendingApi.md#instancesinstancekeysenduploadpost) | **POST** /instances/{instance_key}/send/upload | Upload media.
[**InstancesInstanceKeySendVideoPost**](MessageSendingApi.md#instancesinstancekeysendvideopost) | **POST** /instances/{instance_key}/send/video | Send raw video.



## InstancesInstanceKeySendAudioPost

> APIResponse InstancesInstanceKeySendAudioPost (string instanceKey, string to, InstancesInstanceKeySendAudioPostRequest instancesInstanceKeySendAudioPostRequest, string caption = null)

Send raw audio.

Sends a audio message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
                APIResponse result = apiInstance.InstancesInstanceKeySendAudioPost(instanceKey, to, instancesInstanceKeySendAudioPostRequest, caption);
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


## InstancesInstanceKeySendButtonMediaPost

> APIResponse InstancesInstanceKeySendButtonMediaPost (string instanceKey, ButtonMessageWithMediaPayload data)

Send a button message with a media header.

Sends an interactive button message to the given user. This message also has media header with it. Make sure that all the button ids are unique

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new ButtonMessageWithMediaPayload(); // ButtonMessageWithMediaPayload | Message data

            try
            {
                // Send a button message with a media header.
                APIResponse result = apiInstance.InstancesInstanceKeySendButtonMediaPost(instanceKey, data);
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
 **data** | [**ButtonMessageWithMediaPayload**](ButtonMessageWithMediaPayload.md)| Message data | 

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


## InstancesInstanceKeySendButtonsPost

> APIResponse InstancesInstanceKeySendButtonsPost (string instanceKey, ButtonMessagePayload data)

Send a button message.

Sends an interactive button message to the given user. Make sure that all the button ids are unique

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new ButtonMessagePayload(); // ButtonMessagePayload | Message data

            try
            {
                // Send a button message.
                APIResponse result = apiInstance.InstancesInstanceKeySendButtonsPost(instanceKey, data);
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
 **data** | [**ButtonMessagePayload**](ButtonMessagePayload.md)| Message data | 

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


## InstancesInstanceKeySendContactPost

> APIResponse InstancesInstanceKeySendContactPost (string instanceKey, ContactMessagePayload data)

Send a contact message.

Sends a contact (vcard) message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new ContactMessagePayload(); // ContactMessagePayload | Message data

            try
            {
                // Send a contact message.
                APIResponse result = apiInstance.InstancesInstanceKeySendContactPost(instanceKey, data);
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
 **data** | [**ContactMessagePayload**](ContactMessagePayload.md)| Message data | 

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


## InstancesInstanceKeySendDocumentPost

> APIResponse InstancesInstanceKeySendDocumentPost (string instanceKey, string to, InstancesInstanceKeySendDocumentPostRequest instancesInstanceKeySendDocumentPostRequest, string caption = null)

Send raw document.

Sends a document message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
                APIResponse result = apiInstance.InstancesInstanceKeySendDocumentPost(instanceKey, to, instancesInstanceKeySendDocumentPostRequest, caption);
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


## InstancesInstanceKeySendImagePost

> APIResponse InstancesInstanceKeySendImagePost (string instanceKey, string to, InstancesInstanceKeySendImagePostRequest instancesInstanceKeySendImagePostRequest, string caption = null)

Send raw image.

Sends a image message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
                APIResponse result = apiInstance.InstancesInstanceKeySendImagePost(instanceKey, to, instancesInstanceKeySendImagePostRequest, caption);
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


## InstancesInstanceKeySendListPost

> APIResponse InstancesInstanceKeySendListPost (string instanceKey, ListMessagePayload data)

Send a List message.

Sends an interactive List message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new ListMessagePayload(); // ListMessagePayload | Message data

            try
            {
                // Send a List message.
                APIResponse result = apiInstance.InstancesInstanceKeySendListPost(instanceKey, data);
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
 **data** | [**ListMessagePayload**](ListMessagePayload.md)| Message data | 

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


## InstancesInstanceKeySendLocationPost

> APIResponse InstancesInstanceKeySendLocationPost (string instanceKey, LocationMessagePayload data)

Send a location message.

Sends a location message to the given user. This is static location and does not update Note: The Address and Url fields are optional

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new LocationMessagePayload(); // LocationMessagePayload | Message data

            try
            {
                // Send a location message.
                APIResponse result = apiInstance.InstancesInstanceKeySendLocationPost(instanceKey, data);
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
 **data** | [**LocationMessagePayload**](LocationMessagePayload.md)| Message data | 

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


## InstancesInstanceKeySendMediaPost

> APIResponse InstancesInstanceKeySendMediaPost (string instanceKey, SendMediaPayload data)

Send a media message.

Sends a media message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new SendMediaPayload(); // SendMediaPayload | Message data

            try
            {
                // Send a media message.
                APIResponse result = apiInstance.InstancesInstanceKeySendMediaPost(instanceKey, data);
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
 **data** | [**SendMediaPayload**](SendMediaPayload.md)| Message data | 

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


## InstancesInstanceKeySendPollPost

> APIResponse InstancesInstanceKeySendPollPost (string instanceKey, PollMessagePayload data)

Send a Poll message.

Sends an interactive poll message to the given user. The poll message is a new feature that is currently in beta.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new PollMessagePayload(); // PollMessagePayload | Message data

            try
            {
                // Send a Poll message.
                APIResponse result = apiInstance.InstancesInstanceKeySendPollPost(instanceKey, data);
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
 **data** | [**PollMessagePayload**](PollMessagePayload.md)| Message data | 

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


## InstancesInstanceKeySendTemplateMediaPost

> APIResponse InstancesInstanceKeySendTemplateMediaPost (string instanceKey, TemplateButtonWithMediaPayload data)

Send a template message with media.

Sends an interactive template message with a media header to the given user. Note: The valid button types are \"replyButton\", \"urlButton\", \"callButton\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new TemplateButtonWithMediaPayload(); // TemplateButtonWithMediaPayload | Message data

            try
            {
                // Send a template message with media.
                APIResponse result = apiInstance.InstancesInstanceKeySendTemplateMediaPost(instanceKey, data);
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
 **data** | [**TemplateButtonWithMediaPayload**](TemplateButtonWithMediaPayload.md)| Message data | 

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


## InstancesInstanceKeySendTemplatePost

> APIResponse InstancesInstanceKeySendTemplatePost (string instanceKey, TemplateButtonPayload data)

Send a template message.

Sends an interactive template message to the given user. Note: The valid button types are \"replyButton\", \"urlButton\", \"callButton\"

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new TemplateButtonPayload(); // TemplateButtonPayload | Message data

            try
            {
                // Send a template message.
                APIResponse result = apiInstance.InstancesInstanceKeySendTemplatePost(instanceKey, data);
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
 **data** | [**TemplateButtonPayload**](TemplateButtonPayload.md)| Message data | 

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


## InstancesInstanceKeySendTextPost

> APIResponse InstancesInstanceKeySendTextPost (string instanceKey, TextMessage data)

Send a text message.

Sends a text message to the given user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
            var data = new TextMessage(); // TextMessage | Message data

            try
            {
                // Send a text message.
                APIResponse result = apiInstance.InstancesInstanceKeySendTextPost(instanceKey, data);
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
 **data** | [**TextMessage**](TextMessage.md)| Message data | 

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


## InstancesInstanceKeySendUploadPost

> APIResponse InstancesInstanceKeySendUploadPost (string instanceKey, string type, InstancesInstanceKeySendUploadPostRequest instancesInstanceKeySendUploadPostRequest)

Upload media.

Uploads media to WhatsApp servers and returns the media keys. Store the returned media keys, as you will need them to send media messages

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
                APIResponse result = apiInstance.InstancesInstanceKeySendUploadPost(instanceKey, type, instancesInstanceKeySendUploadPostRequest);
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


## InstancesInstanceKeySendVideoPost

> APIResponse InstancesInstanceKeySendVideoPost (string instanceKey, string to, InstancesInstanceKeySendVideoPostRequest instancesInstanceKeySendVideoPostRequest, string caption = null)

Send raw video.

Sends a video message by uploading to the WhatsApp servers every time. This is not recommended for bulk sending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

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
                APIResponse result = apiInstance.InstancesInstanceKeySendVideoPost(instanceKey, to, instancesInstanceKeySendVideoPostRequest, caption);
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

