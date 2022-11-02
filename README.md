# Org.OpenAPITools - the C# library for the WhatsAPI Go

The V2 of WhatsAPI Go

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "/api";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

## Documentation for API Endpoints

All URIs are relative to */api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*GroupManagementApi* | [**InstancesInstanceKeyGroupsAdminGet**](docs/GroupManagementApi.md#instancesinstancekeygroupsadminget) | **GET** /instances/{instance_key}/groups/admin | Get admin groupss.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsCreatePost**](docs/GroupManagementApi.md#instancesinstancekeygroupscreatepost) | **POST** /instances/{instance_key}/groups/create | Create group.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGet**](docs/GroupManagementApi.md#instancesinstancekeygroupsget) | **GET** /instances/{instance_key}/groups/ | Get all groups.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdAnnouncePut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidannounceput) | **PUT** /instances/{instance_key}/groups/{group_id}/announce | Set group announce.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdDelete**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupiddelete) | **DELETE** /instances/{instance_key}/groups/{group_id}/ | Leaves the group.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdDescriptionPut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupiddescriptionput) | **PUT** /instances/{instance_key}/groups/{group_id}/description | Set group description.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdGet**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidget) | **GET** /instances/{instance_key}/groups/{group_id} | Get group.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdInviteCodeGet**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidinvitecodeget) | **GET** /instances/{instance_key}/groups/{group_id}/invite-code | Get group invite code.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdLockPut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidlockput) | **PUT** /instances/{instance_key}/groups/{group_id}/lock | Set group locked.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdNamePut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidnameput) | **PUT** /instances/{instance_key}/groups/{group_id}/name | Set group name.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdParticipantsAddPost**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantsaddpost) | **POST** /instances/{instance_key}/groups/{group_id}/participants/add | Add participant.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantsdemoteput) | **PUT** /instances/{instance_key}/groups/{group_id}/participants/demote | Demote participant.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantspromoteput) | **PUT** /instances/{instance_key}/groups/{group_id}/participants/promote | Promote participant.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidparticipantsremovedelete) | **DELETE** /instances/{instance_key}/groups/{group_id}/participants/remove | Remove participant.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsGroupIdProfilePicPut**](docs/GroupManagementApi.md#instancesinstancekeygroupsgroupidprofilepicput) | **PUT** /instances/{instance_key}/groups/{group_id}/profile-pic | Set group picture.
*GroupManagementApi* | [**InstancesInstanceKeyGroupsInviteInfoGet**](docs/GroupManagementApi.md#instancesinstancekeygroupsinviteinfoget) | **GET** /instances/{instance_key}/groups/invite-info | Get group from invite link.
*InstanceApi* | [**InstancesCreateGet**](docs/InstanceApi.md#instancescreateget) | **GET** /instances/create | Creates a new instance key.
*InstanceApi* | [**InstancesInstanceKeyContactsGet**](docs/InstanceApi.md#instancesinstancekeycontactsget) | **GET** /instances/{instance_key}/contacts | Get contacts.
*InstanceApi* | [**InstancesInstanceKeyDeleteDelete**](docs/InstanceApi.md#instancesinstancekeydeletedelete) | **DELETE** /instances/{instance_key}/delete | Delete Instance.
*InstanceApi* | [**InstancesInstanceKeyGet**](docs/InstanceApi.md#instancesinstancekeyget) | **GET** /instances/{instance_key}/ | Get Instance.
*InstanceApi* | [**InstancesInstanceKeyLogoutDelete**](docs/InstanceApi.md#instancesinstancekeylogoutdelete) | **DELETE** /instances/{instance_key}/logout | Logout Instance.
*InstanceApi* | [**InstancesInstanceKeyQrcodeGet**](docs/InstanceApi.md#instancesinstancekeyqrcodeget) | **GET** /instances/{instance_key}/qrcode | Get QrCode.
*InstanceApi* | [**InstancesInstanceKeyWebhookPut**](docs/InstanceApi.md#instancesinstancekeywebhookput) | **PUT** /instances/{instance_key}/webhook | Change Webhook url.
*InstanceApi* | [**InstancesListGet**](docs/InstanceApi.md#instanceslistget) | **GET** /instances/list | Get all instances.
*MessageSendingApi* | [**InstancesInstanceKeyBusinessCatalogGet**](docs/MessageSendingApi.md#instancesinstancekeybusinesscatalogget) | **GET** /instances/{instance_key}/business/catalog | Fetches the catlog.
*MessageSendingApi* | [**InstancesInstanceKeySendAudioPost**](docs/MessageSendingApi.md#instancesinstancekeysendaudiopost) | **POST** /instances/{instance_key}/send/audio | Send raw audio.
*MessageSendingApi* | [**InstancesInstanceKeySendButtonMediaPost**](docs/MessageSendingApi.md#instancesinstancekeysendbuttonmediapost) | **POST** /instances/{instance_key}/send/button-media | Send a button message with a media header.
*MessageSendingApi* | [**InstancesInstanceKeySendButtonsPost**](docs/MessageSendingApi.md#instancesinstancekeysendbuttonspost) | **POST** /instances/{instance_key}/send/buttons | Send a button message.
*MessageSendingApi* | [**InstancesInstanceKeySendContactPost**](docs/MessageSendingApi.md#instancesinstancekeysendcontactpost) | **POST** /instances/{instance_key}/send/contact | Send a contact message.
*MessageSendingApi* | [**InstancesInstanceKeySendDocumentPost**](docs/MessageSendingApi.md#instancesinstancekeysenddocumentpost) | **POST** /instances/{instance_key}/send/document | Send raw document.
*MessageSendingApi* | [**InstancesInstanceKeySendImagePost**](docs/MessageSendingApi.md#instancesinstancekeysendimagepost) | **POST** /instances/{instance_key}/send/image | Send raw image.
*MessageSendingApi* | [**InstancesInstanceKeySendListPost**](docs/MessageSendingApi.md#instancesinstancekeysendlistpost) | **POST** /instances/{instance_key}/send/list | Send a List message.
*MessageSendingApi* | [**InstancesInstanceKeySendLocationPost**](docs/MessageSendingApi.md#instancesinstancekeysendlocationpost) | **POST** /instances/{instance_key}/send/location | Send a location message.
*MessageSendingApi* | [**InstancesInstanceKeySendMediaPost**](docs/MessageSendingApi.md#instancesinstancekeysendmediapost) | **POST** /instances/{instance_key}/send/media | Send a media message.
*MessageSendingApi* | [**InstancesInstanceKeySendPollPost**](docs/MessageSendingApi.md#instancesinstancekeysendpollpost) | **POST** /instances/{instance_key}/send/poll | Send a Poll message with media.
*MessageSendingApi* | [**InstancesInstanceKeySendTemplateMediaPost**](docs/MessageSendingApi.md#instancesinstancekeysendtemplatemediapost) | **POST** /instances/{instance_key}/send/template-media | Send a template message with media.
*MessageSendingApi* | [**InstancesInstanceKeySendTemplatePost**](docs/MessageSendingApi.md#instancesinstancekeysendtemplatepost) | **POST** /instances/{instance_key}/send/template | Send a template message.
*MessageSendingApi* | [**InstancesInstanceKeySendTextPost**](docs/MessageSendingApi.md#instancesinstancekeysendtextpost) | **POST** /instances/{instance_key}/send/text | Send a text message.
*MessageSendingApi* | [**InstancesInstanceKeySendUploadPost**](docs/MessageSendingApi.md#instancesinstancekeysenduploadpost) | **POST** /instances/{instance_key}/send/upload | Upload media.
*MessageSendingApi* | [**InstancesInstanceKeySendVideoPost**](docs/MessageSendingApi.md#instancesinstancekeysendvideopost) | **POST** /instances/{instance_key}/send/video | Send raw video.
*MiscellaneousApi* | [**InstancesInstanceKeyMiscProfilePicGet**](docs/MiscellaneousApi.md#instancesinstancekeymiscprofilepicget) | **GET** /instances/{instance_key}/misc/profile-pic | Get profile pic.
*MiscellaneousApi* | [**InstancesInstanceKeyMiscUserInfoPost**](docs/MiscellaneousApi.md#instancesinstancekeymiscuserinfopost) | **POST** /instances/{instance_key}/misc/user-info | Fetches the users info.


## Documentation for Models

 - [Model.InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest](docs/InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest.md)
 - [Model.InstancesInstanceKeySendAudioPostRequest](docs/InstancesInstanceKeySendAudioPostRequest.md)
 - [Model.InstancesInstanceKeySendDocumentPostRequest](docs/InstancesInstanceKeySendDocumentPostRequest.md)
 - [Model.InstancesInstanceKeySendImagePostRequest](docs/InstancesInstanceKeySendImagePostRequest.md)
 - [Model.InstancesInstanceKeySendUploadPostRequest](docs/InstancesInstanceKeySendUploadPostRequest.md)
 - [Model.InstancesInstanceKeySendVideoPostRequest](docs/InstancesInstanceKeySendVideoPostRequest.md)
 - [Model.MainAPIResponse](docs/MainAPIResponse.md)
 - [Model.StructsButtonMessagePayload](docs/StructsButtonMessagePayload.md)
 - [Model.StructsButtonMessageWithMediaPayload](docs/StructsButtonMessageWithMediaPayload.md)
 - [Model.StructsContactMessagePayload](docs/StructsContactMessagePayload.md)
 - [Model.StructsContactMessagePayloadVcard](docs/StructsContactMessagePayloadVcard.md)
 - [Model.StructsFileUpload](docs/StructsFileUpload.md)
 - [Model.StructsGroupCreatePayload](docs/StructsGroupCreatePayload.md)
 - [Model.StructsGroupUpdateDescriptionPayload](docs/StructsGroupUpdateDescriptionPayload.md)
 - [Model.StructsGroupUpdateNamePayload](docs/StructsGroupUpdateNamePayload.md)
 - [Model.StructsGroupUpdateParticipantsPayload](docs/StructsGroupUpdateParticipantsPayload.md)
 - [Model.StructsListItem](docs/StructsListItem.md)
 - [Model.StructsListMessagePayload](docs/StructsListMessagePayload.md)
 - [Model.StructsListSection](docs/StructsListSection.md)
 - [Model.StructsLocationMessagePayload](docs/StructsLocationMessagePayload.md)
 - [Model.StructsLocationMessagePayloadLocation](docs/StructsLocationMessagePayloadLocation.md)
 - [Model.StructsPollMessagePayload](docs/StructsPollMessagePayload.md)
 - [Model.StructsReplyButton](docs/StructsReplyButton.md)
 - [Model.StructsSendMediaPayload](docs/StructsSendMediaPayload.md)
 - [Model.StructsTemplateButton](docs/StructsTemplateButton.md)
 - [Model.StructsTemplateButtonPayload](docs/StructsTemplateButtonPayload.md)
 - [Model.StructsTemplateButtonWithMediaPayload](docs/StructsTemplateButtonWithMediaPayload.md)
 - [Model.StructsTextMessage](docs/StructsTextMessage.md)
 - [Model.StructsUserInfoPayload](docs/StructsUserInfoPayload.md)
 - [Model.StructsWebhookPayload](docs/StructsWebhookPayload.md)


## Documentation for Authorization


### ApiKeyAuth

- **Type**: API key

- **API key parameter name**: Authorization
- **Location**: HTTP header

