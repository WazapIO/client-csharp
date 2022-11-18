# WhatsAPI.whatsapi.GroupManagementApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddParticipant**](GroupManagementApi.md#addparticipant) | **POST** /instances/{instance_key}/groups/{group_id}/participants/add | Add participant.
[**CreateGroup**](GroupManagementApi.md#creategroup) | **POST** /instances/{instance_key}/groups/create | Create group.
[**DemoteParticipant**](GroupManagementApi.md#demoteparticipant) | **PUT** /instances/{instance_key}/groups/{group_id}/participants/demote | Demote participant.
[**GetAdminGroups**](GroupManagementApi.md#getadmingroups) | **GET** /instances/{instance_key}/groups/admin | Get admin groups.
[**GetAllGroups**](GroupManagementApi.md#getallgroups) | **GET** /instances/{instance_key}/groups/ | Get all groups.
[**GetAllParticipants**](GroupManagementApi.md#getallparticipants) | **GET** /instances/{instance_key}/groups/{group_id}/participants | Get all participants.
[**GetGroup**](GroupManagementApi.md#getgroup) | **GET** /instances/{instance_key}/groups/{group_id} | Get group.
[**GetGroupFromInviteLink**](GroupManagementApi.md#getgroupfrominvitelink) | **GET** /instances/{instance_key}/groups/invite-info | Get group from invite link.
[**GetGroupInviteCode**](GroupManagementApi.md#getgroupinvitecode) | **GET** /instances/{instance_key}/groups/{group_id}/invite-code | Get group invite code.
[**JoinGroupWithLink**](GroupManagementApi.md#joingroupwithlink) | **GET** /instances/{instance_key}/groups/join | Join group with invite code.
[**LeaveGroup**](GroupManagementApi.md#leavegroup) | **DELETE** /instances/{instance_key}/groups/{group_id}/ | Leaves the group.
[**PromoteParticipant**](GroupManagementApi.md#promoteparticipant) | **PUT** /instances/{instance_key}/groups/{group_id}/participants/promote | Promote participant.
[**RemoveParticipant**](GroupManagementApi.md#removeparticipant) | **DELETE** /instances/{instance_key}/groups/{group_id}/participants/remove | Remove participant.
[**SetGroupAnnounce**](GroupManagementApi.md#setgroupannounce) | **PUT** /instances/{instance_key}/groups/{group_id}/announce | Set group announce.
[**SetGroupDescription**](GroupManagementApi.md#setgroupdescription) | **PUT** /instances/{instance_key}/groups/{group_id}/description | Set group description.
[**SetGroupLocked**](GroupManagementApi.md#setgrouplocked) | **PUT** /instances/{instance_key}/groups/{group_id}/lock | Set group locked.
[**SetGroupName**](GroupManagementApi.md#setgroupname) | **PUT** /instances/{instance_key}/groups/{group_id}/name | Set group name.
[**SetGroupPicture**](GroupManagementApi.md#setgrouppicture) | **PUT** /instances/{instance_key}/groups/{group_id}/profile-pic | Set group picture.



## AddParticipant

> APIResponse AddParticipant (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

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
    public class AddParticipantExample
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
                APIResponse result = apiInstance.AddParticipant(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.AddParticipant: " + e.Message );
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


## CreateGroup

> APIResponse CreateGroup (string instanceKey, GroupCreatePayload data)

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
    public class CreateGroupExample
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
                APIResponse result = apiInstance.CreateGroup(instanceKey, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.CreateGroup: " + e.Message );
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


## DemoteParticipant

> APIResponse DemoteParticipant (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

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
    public class DemoteParticipantExample
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
                APIResponse result = apiInstance.DemoteParticipant(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.DemoteParticipant: " + e.Message );
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


## GetAdminGroups

> APIResponse GetAdminGroups (string instanceKey)

Get admin groups.

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
    public class GetAdminGroupsExample
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
                // Get admin groups.
                APIResponse result = apiInstance.GetAdminGroups(instanceKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.GetAdminGroups: " + e.Message );
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


## GetAllGroups

> APIResponse GetAllGroups (string instanceKey, string includeParticipants = null)

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
    public class GetAllGroupsExample
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
                APIResponse result = apiInstance.GetAllGroups(instanceKey, includeParticipants);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.GetAllGroups: " + e.Message );
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


## GetAllParticipants

> APIResponse GetAllParticipants (string instanceKey, string groupId)

Get all participants.

Returns all participants of the group.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class GetAllParticipantsExample
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
                // Get all participants.
                APIResponse result = apiInstance.GetAllParticipants(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.GetAllParticipants: " + e.Message );
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


## GetGroup

> APIResponse GetGroup (string instanceKey, string groupId)

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
    public class GetGroupExample
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
                APIResponse result = apiInstance.GetGroup(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.GetGroup: " + e.Message );
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


## GetGroupFromInviteLink

> APIResponse GetGroupFromInviteLink (string instanceKey, string inviteLink)

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
    public class GetGroupFromInviteLinkExample
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
                APIResponse result = apiInstance.GetGroupFromInviteLink(instanceKey, inviteLink);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.GetGroupFromInviteLink: " + e.Message );
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


## GetGroupInviteCode

> APIResponse GetGroupInviteCode (string instanceKey, string groupId)

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
    public class GetGroupInviteCodeExample
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
                APIResponse result = apiInstance.GetGroupInviteCode(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.GetGroupInviteCode: " + e.Message );
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


## JoinGroupWithLink

> APIResponse JoinGroupWithLink (string instanceKey, string inviteCode)

Join group with invite code.

Joins a group with group invite link. An invite link is a link that can be used to join a group. It is usually in the format https://chat.whatsapp.com/{invitecode} You have to put invite_code in the url of the request. The invite code is the part after https://chat.whatsapp.com/ For example, if the invite link is https://chat.whatsapp.com/dsfsf34r3d3dsds, then the invite code is `dsfsf34r3d3dsds“

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WhatsAPI.whatsapi;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace Example
{
    public class JoinGroupWithLinkExample
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
            var inviteCode = "inviteCode_example";  // string | The invite code of group you want to join

            try
            {
                // Join group with invite code.
                APIResponse result = apiInstance.JoinGroupWithLink(instanceKey, inviteCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.JoinGroupWithLink: " + e.Message );
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
 **inviteCode** | **string**| The invite code of group you want to join | 

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


## LeaveGroup

> APIResponse LeaveGroup (string instanceKey, string groupId)

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
    public class LeaveGroupExample
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
                APIResponse result = apiInstance.LeaveGroup(instanceKey, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.LeaveGroup: " + e.Message );
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


## PromoteParticipant

> APIResponse PromoteParticipant (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

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
    public class PromoteParticipantExample
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
                APIResponse result = apiInstance.PromoteParticipant(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.PromoteParticipant: " + e.Message );
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


## RemoveParticipant

> APIResponse RemoveParticipant (string instanceKey, string groupId, GroupUpdateParticipantsPayload data)

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
    public class RemoveParticipantExample
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
                APIResponse result = apiInstance.RemoveParticipant(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.RemoveParticipant: " + e.Message );
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


## SetGroupAnnounce

> APIResponse SetGroupAnnounce (string instanceKey, bool announce, string groupId)

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
    public class SetGroupAnnounceExample
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
                APIResponse result = apiInstance.SetGroupAnnounce(instanceKey, announce, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.SetGroupAnnounce: " + e.Message );
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


## SetGroupDescription

> APIResponse SetGroupDescription (string instanceKey, string groupId, GroupUpdateDescriptionPayload data)

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
    public class SetGroupDescriptionExample
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
                APIResponse result = apiInstance.SetGroupDescription(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.SetGroupDescription: " + e.Message );
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


## SetGroupLocked

> APIResponse SetGroupLocked (string instanceKey, bool locked, string groupId)

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
    public class SetGroupLockedExample
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
                APIResponse result = apiInstance.SetGroupLocked(instanceKey, locked, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.SetGroupLocked: " + e.Message );
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


## SetGroupName

> APIResponse SetGroupName (string instanceKey, string groupId, GroupUpdateNamePayload data)

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
    public class SetGroupNameExample
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
                APIResponse result = apiInstance.SetGroupName(instanceKey, groupId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.SetGroupName: " + e.Message );
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


## SetGroupPicture

> APIResponse SetGroupPicture (string instanceKey, string groupId, SetGroupPictureRequest setGroupPictureRequest)

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
    public class SetGroupPictureExample
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
            var setGroupPictureRequest = new SetGroupPictureRequest(); // SetGroupPictureRequest | 

            try
            {
                // Set group picture.
                APIResponse result = apiInstance.SetGroupPicture(instanceKey, groupId, setGroupPictureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupManagementApi.SetGroupPicture: " + e.Message );
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
 **setGroupPictureRequest** | [**SetGroupPictureRequest**](SetGroupPictureRequest.md)|  | 

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

