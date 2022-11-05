# WhatsAPI.whatsapi.GroupManagementApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstancesInstanceKeyGroupsAdminGet**](GroupManagementApi.md#instancesinstancekeygroupsadminget) | **GET** /instances/{instance_key}/groups/admin | Get admin groupss.
[**InstancesInstanceKeyGroupsCreatePost**](GroupManagementApi.md#instancesinstancekeygroupscreatepost) | **POST** /instances/{instance_key}/groups/create | Create group.
[**InstancesInstanceKeyGroupsGet**](GroupManagementApi.md#instancesinstancekeygroupsget) | **GET** /instances/{instance_key}/groups/ | Get all groups.
[**InstancesInstanceKeyGroupsGroupIdAnnouncePut**](GroupManagementApi.md#instancesinstancekeygroupsgroupidannounceput) | **PUT** /instances/{instance_key}/groups/{group_id}/announce | Set group announce.
[**InstancesInstanceKeyGroupsGroupIdDelete**](GroupManagementApi.md#instancesinstancekeygroupsgroupiddelete) | **DELETE** /instances/{instance_key}/groups/{group_id}/ | Leaves the group.
[**InstancesInstanceKeyGroupsGroupIdDescriptionPut**](GroupManagementApi.md#instancesinstancekeygroupsgroupiddescriptionput) | **PUT** /instances/{instance_key}/groups/{group_id}/description | Set group description.
[**InstancesInstanceKeyGroupsGroupIdGet**](GroupManagementApi.md#instancesinstancekeygroupsgroupidget) | **GET** /instances/{instance_key}/groups/{group_id} | Get group.
[**InstancesInstanceKeyGroupsGroupIdInviteCodeGet**](GroupManagementApi.md#instancesinstancekeygroupsgroupidinvitecodeget) | **GET** /instances/{instance_key}/groups/{group_id}/invite-code | Get group invite code.
[**InstancesInstanceKeyGroupsGroupIdLockPut**](GroupManagementApi.md#instancesinstancekeygroupsgroupidlockput) | **PUT** /instances/{instance_key}/groups/{group_id}/lock | Set group locked.
[**InstancesInstanceKeyGroupsGroupIdNamePut**](GroupManagementApi.md#instancesinstancekeygroupsgroupidnameput) | **PUT** /instances/{instance_key}/groups/{group_id}/name | Set group name.
[**InstancesInstanceKeyGroupsGroupIdParticipantsAddPost**](GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantsaddpost) | **POST** /instances/{instance_key}/groups/{group_id}/participants/add | Add participant.
[**InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut**](GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantsdemoteput) | **PUT** /instances/{instance_key}/groups/{group_id}/participants/demote | Demote participant.
[**InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut**](GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantspromoteput) | **PUT** /instances/{instance_key}/groups/{group_id}/participants/promote | Promote participant.
[**InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete**](GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantsremovedelete) | **DELETE** /instances/{instance_key}/groups/{group_id}/participants/remove | Remove participant.
[**InstancesInstanceKeyGroupsGroupIdProfilePicPut**](GroupManagementApi.md#instancesinstancekeygroupsgroupidprofilepicput) | **PUT** /instances/{instance_key}/groups/{group_id}/profile-pic | Set group picture.
[**InstancesInstanceKeyGroupsInviteInfoGet**](GroupManagementApi.md#instancesinstancekeygroupsinviteinfoget) | **GET** /instances/{instance_key}/groups/invite-info | Get group from invite link.



## InstancesInstanceKeyGroupsAdminGet

> APIResponse InstancesInstanceKeyGroupsAdminGet (string instanceKey)

Get admin groupss.

Returns list of all groups in which you are admin.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsAdminGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key

            try
            {
                // Get admin groupss.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsAdminGet(instanceKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsAdminGet: " + e.Message );
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


## InstancesInstanceKeyGroupsCreatePost

> APIResponse InstancesInstanceKeyGroupsCreatePost (string instanceKey, GroupCreatePayload data)

Create group.

Creates a group with the participant data. The creator is automatically added to the group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsCreatePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var data = new GroupCreatePayload(); // GroupCreatePayload | Group create payload

            try
            {
                // Create group.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsCreatePost(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsCreatePost: " + e.Message );
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
 **data** | [**GroupCreatePayload**](GroupCreatePayload.md)| Group create payload | 

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


## InstancesInstanceKeyGroupsGet

> APIResponse InstancesInstanceKeyGroupsGet (string instanceKey, string includeParticipants = null)

Get all groups.

Returns list of all groups with participants data. Set include_participants to false to exclude participants data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var includeParticipants = "false";  // string | Include participants data (optional)  (default to true)

            try
            {
                // Get all groups.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGet(instanceKey, includeParticipants);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGet: " + e.Message );
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
 **includeParticipants** | **string**| Include participants data | [optional] [default to true]

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


## InstancesInstanceKeyGroupsGroupIdAnnouncePut

> APIResponse InstancesInstanceKeyGroupsGroupIdAnnouncePut (string instanceKey, bool announce, string groupId)

Set group announce.

Set if non-admins are allowed to send messages in groups

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdAnnouncePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var announce = true;  // bool | Announce status (default to false)
            var groupId = "groupId_example";  // string | Group id of the group

            try
            {
                // Set group announce.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdAnnouncePut(instanceKey, announce, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdAnnouncePut: " + e.Message );
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
 **announce** | **bool**| Announce status | [default to false]
 **groupId** | **string**| Group id of the group | 

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


## InstancesInstanceKeyGroupsGroupIdDelete

> APIResponse InstancesInstanceKeyGroupsGroupIdDelete (string instanceKey, string groupId)

Leaves the group.

Leaves the specified group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group

            try
            {
                // Leaves the group.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdDelete(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdDelete: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 

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


## InstancesInstanceKeyGroupsGroupIdDescriptionPut

> APIResponse InstancesInstanceKeyGroupsGroupIdDescriptionPut (string instanceKey, string groupId, GroupUpdateDescriptionPayload data)

Set group description.

Changes the group description

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdDescriptionPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var data = new GroupUpdateDescriptionPayload(); // GroupUpdateDescriptionPayload | Group description data

            try
            {
                // Set group description.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdDescriptionPut(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdDescriptionPut: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **data** | [**GroupUpdateDescriptionPayload**](GroupUpdateDescriptionPayload.md)| Group description data | 

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


## InstancesInstanceKeyGroupsGroupIdGet

> APIResponse InstancesInstanceKeyGroupsGroupIdGet (string instanceKey, string groupId)

Get group.

Fetches the group data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group

            try
            {
                // Get group.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdGet(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdGet: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 

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


## InstancesInstanceKeyGroupsGroupIdInviteCodeGet

> APIResponse InstancesInstanceKeyGroupsGroupIdInviteCodeGet (string instanceKey, string groupId)

Get group invite code.

Gets the invite code of the group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdInviteCodeGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group

            try
            {
                // Get group invite code.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdInviteCodeGet(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdInviteCodeGet: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 

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


## InstancesInstanceKeyGroupsGroupIdLockPut

> APIResponse InstancesInstanceKeyGroupsGroupIdLockPut (string instanceKey, bool locked, string groupId)

Set group locked.

Set if non-admins are allowed to change the group dp and other stuff

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdLockPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var locked = true;  // bool | Locked status (default to false)
            var groupId = "groupId_example";  // string | Group id of the group

            try
            {
                // Set group locked.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdLockPut(instanceKey, locked, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdLockPut: " + e.Message );
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
 **locked** | **bool**| Locked status | [default to false]
 **groupId** | **string**| Group id of the group | 

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


## InstancesInstanceKeyGroupsGroupIdNamePut

> APIResponse InstancesInstanceKeyGroupsGroupIdNamePut (string instanceKey, string groupId, GroupUpdateNamePayload data)

Set group name.

Changes the group name. The max limit is 22 chars

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdNamePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var data = new GroupUpdateNamePayload(); // GroupUpdateNamePayload | Group name data

            try
            {
                // Set group name.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdNamePut(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdNamePut: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **data** | [**GroupUpdateNamePayload**](GroupUpdateNamePayload.md)| Group name data | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsAddPost

> APIResponse InstancesInstanceKeyGroupsGroupIdParticipantsAddPost (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

Add participant.

Handles adding participants to a group. You must be admin in the group or the query will fail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdParticipantsAddPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var data = new GroupUpdateParticipantsPayload(); // GroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Add participant.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsAddPost(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdParticipantsAddPost: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **data** | [**GroupUpdateParticipantsPayload**](GroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut

> APIResponse InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

Demote participant.

Demotes admins in groups. You must be admin in the group or the query will fail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdParticipantsDemotePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var data = new GroupUpdateParticipantsPayload(); // GroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Demote participant.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **data** | [**GroupUpdateParticipantsPayload**](GroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut

> APIResponse InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

Promote participant.

Promotes participants to admin. You must be admin in the group or the query will fail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdParticipantsPromotePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var data = new GroupUpdateParticipantsPayload(); // GroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Promote participant.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **data** | [**GroupUpdateParticipantsPayload**](GroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete

> APIResponse InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

Remove participant.

Handles removing participants from a group. You must be admin in the group or the query will fail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var data = new GroupUpdateParticipantsPayload(); // GroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Remove participant.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **data** | [**GroupUpdateParticipantsPayload**](GroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdProfilePicPut

> APIResponse InstancesInstanceKeyGroupsGroupIdProfilePicPut (string instanceKey, string groupId, InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest instancesInstanceKeyGroupsGroupIdProfilePicPutRequest)

Set group picture.

Changes the group profile picture. Currently it only seems to accept JPEG images only

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsGroupIdProfilePicPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var groupId = "groupId_example";  // string | Group id of the group
            var instancesInstanceKeyGroupsGroupIdProfilePicPutRequest = new InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest(); // InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest | 

            try
            {
                // Set group picture.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdProfilePicPut(instanceKey, groupId, instancesInstanceKeyGroupsGroupIdProfilePicPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsGroupIdProfilePicPut: " + e.Message );
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
 **groupId** | **string**| Group id of the group | 
 **instancesInstanceKeyGroupsGroupIdProfilePicPutRequest** | [**InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest**](InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest.md)|  | 

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


## InstancesInstanceKeyGroupsInviteInfoGet

> APIResponse InstancesInstanceKeyGroupsInviteInfoGet (string instanceKey, string inviteLink)

Get group from invite link.

Gets a group info from an invite link. An invite link is a link that can be used to join a group. It is usually in the format https://chat.whatsapp.com/{invitecode}

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class InstancesInstanceKeyGroupsInviteInfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupManagementApi(Configuration.Default);
            var instanceKey = "instanceKey_example";  // string | Instance key
            var inviteLink = "inviteLink_example";  // string | The invite link to check

            try
            {
                // Get group from invite link.
                APIResponse result = apiInstance.InstancesInstanceKeyGroupsInviteInfoGet(instanceKey, inviteLink);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.InstancesInstanceKeyGroupsInviteInfoGet: " + e.Message );
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
 **inviteLink** | **string**| The invite link to check | 

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

