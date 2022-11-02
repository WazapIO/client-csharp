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

> MainAPIResponse InstancesInstanceKeyGroupsAdminGet (string instanceKey)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsAdminGet(instanceKey);
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


## InstancesInstanceKeyGroupsCreatePost

> MainAPIResponse InstancesInstanceKeyGroupsCreatePost (string instanceKey, StructsGroupCreatePayload data)

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
            var data = new StructsGroupCreatePayload(); // StructsGroupCreatePayload | Group create payload

            try
            {
                // Create group.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsCreatePost(instanceKey, data);
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
 **data** | [**StructsGroupCreatePayload**](StructsGroupCreatePayload.md)| Group create payload | 

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


## InstancesInstanceKeyGroupsGet

> MainAPIResponse InstancesInstanceKeyGroupsGet (string instanceKey, string includeParticipants = null)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGet(instanceKey, includeParticipants);
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


## InstancesInstanceKeyGroupsGroupIdAnnouncePut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdAnnouncePut (string instanceKey, bool announce, string groupId)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdAnnouncePut(instanceKey, announce, groupId);
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


## InstancesInstanceKeyGroupsGroupIdDelete

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdDelete (string instanceKey, string groupId)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdDelete(instanceKey, groupId);
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


## InstancesInstanceKeyGroupsGroupIdDescriptionPut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdDescriptionPut (string instanceKey, string groupId, StructsGroupUpdateDescriptionPayload data)

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
            var data = new StructsGroupUpdateDescriptionPayload(); // StructsGroupUpdateDescriptionPayload | Group description data

            try
            {
                // Set group description.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdDescriptionPut(instanceKey, groupId, data);
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
 **data** | [**StructsGroupUpdateDescriptionPayload**](StructsGroupUpdateDescriptionPayload.md)| Group description data | 

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


## InstancesInstanceKeyGroupsGroupIdGet

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdGet (string instanceKey, string groupId)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdGet(instanceKey, groupId);
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


## InstancesInstanceKeyGroupsGroupIdInviteCodeGet

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdInviteCodeGet (string instanceKey, string groupId)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdInviteCodeGet(instanceKey, groupId);
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


## InstancesInstanceKeyGroupsGroupIdLockPut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdLockPut (string instanceKey, bool locked, string groupId)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdLockPut(instanceKey, locked, groupId);
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


## InstancesInstanceKeyGroupsGroupIdNamePut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdNamePut (string instanceKey, string groupId, StructsGroupUpdateNamePayload data)

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
            var data = new StructsGroupUpdateNamePayload(); // StructsGroupUpdateNamePayload | Group name data

            try
            {
                // Set group name.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdNamePut(instanceKey, groupId, data);
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
 **data** | [**StructsGroupUpdateNamePayload**](StructsGroupUpdateNamePayload.md)| Group name data | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsAddPost

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdParticipantsAddPost (string instanceKey, string groupId, StructsGroupUpdateParticipantsPayload data)

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
            var data = new StructsGroupUpdateParticipantsPayload(); // StructsGroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Add participant.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsAddPost(instanceKey, groupId, data);
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
 **data** | [**StructsGroupUpdateParticipantsPayload**](StructsGroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut (string instanceKey, string groupId, StructsGroupUpdateParticipantsPayload data)

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
            var data = new StructsGroupUpdateParticipantsPayload(); // StructsGroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Demote participant.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut(instanceKey, groupId, data);
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
 **data** | [**StructsGroupUpdateParticipantsPayload**](StructsGroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut (string instanceKey, string groupId, StructsGroupUpdateParticipantsPayload data)

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
            var data = new StructsGroupUpdateParticipantsPayload(); // StructsGroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Promote participant.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut(instanceKey, groupId, data);
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
 **data** | [**StructsGroupUpdateParticipantsPayload**](StructsGroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete (string instanceKey, string groupId, StructsGroupUpdateParticipantsPayload data)

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
            var data = new StructsGroupUpdateParticipantsPayload(); // StructsGroupUpdateParticipantsPayload | Group update payload

            try
            {
                // Remove participant.
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete(instanceKey, groupId, data);
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
 **data** | [**StructsGroupUpdateParticipantsPayload**](StructsGroupUpdateParticipantsPayload.md)| Group update payload | 

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


## InstancesInstanceKeyGroupsGroupIdProfilePicPut

> MainAPIResponse InstancesInstanceKeyGroupsGroupIdProfilePicPut (string instanceKey, string groupId, InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest instancesInstanceKeyGroupsGroupIdProfilePicPutRequest)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsGroupIdProfilePicPut(instanceKey, groupId, instancesInstanceKeyGroupsGroupIdProfilePicPutRequest);
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


## InstancesInstanceKeyGroupsInviteInfoGet

> MainAPIResponse InstancesInstanceKeyGroupsInviteInfoGet (string instanceKey, string inviteLink)

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
                MainAPIResponse result = apiInstance.InstancesInstanceKeyGroupsInviteInfoGet(instanceKey, inviteLink);
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

