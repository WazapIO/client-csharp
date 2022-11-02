/*
 * WhatsAPI Go
 *
 * The V2 of WhatsAPI Go
 *
 * The version of the OpenAPI document: 2.0
 * Contact: manjit@sponsorbook.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.whatsapi.Client;
using com.whatsapi.Api;
using com.whatsapi.Model;

namespace com.whatsapi.Test
{
    /// <summary>
    ///  Class for testing GroupManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupManagementApiTests
    {
        private GroupManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GroupManagementApi
            //Assert.IsInstanceOf(typeof(GroupManagementApi), instance);
        }

        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsAdminGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsAdminGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyGroupsAdminGet(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsCreatePost
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //StructsGroupCreatePayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsCreatePost(instanceKey, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string includeParticipants = null;
            //var response = instance.InstancesInstanceKeyGroupsGet(instanceKey, includeParticipants);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdAnnouncePut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdAnnouncePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //bool announce = null;
            //string groupId = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdAnnouncePut(instanceKey, announce, groupId);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdDelete
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdDelete(instanceKey, groupId);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdDescriptionPut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdDescriptionPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //StructsGroupUpdateDescriptionPayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdDescriptionPut(instanceKey, groupId, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdGet(instanceKey, groupId);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdInviteCodeGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdInviteCodeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdInviteCodeGet(instanceKey, groupId);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdLockPut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdLockPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //bool locked = null;
            //string groupId = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdLockPut(instanceKey, locked, groupId);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdNamePut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdNamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //StructsGroupUpdateNamePayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdNamePut(instanceKey, groupId, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdParticipantsAddPost
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdParticipantsAddPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //StructsGroupUpdateParticipantsPayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdParticipantsAddPost(instanceKey, groupId, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdParticipantsDemotePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //StructsGroupUpdateParticipantsPayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdParticipantsDemotePut(instanceKey, groupId, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdParticipantsPromotePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //StructsGroupUpdateParticipantsPayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdParticipantsPromotePut(instanceKey, groupId, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //StructsGroupUpdateParticipantsPayload data = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdParticipantsRemoveDelete(instanceKey, groupId, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsGroupIdProfilePicPut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsGroupIdProfilePicPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string groupId = null;
            //InstancesInstanceKeyGroupsGroupIdProfilePicPutRequest instancesInstanceKeyGroupsGroupIdProfilePicPutRequest = null;
            //var response = instance.InstancesInstanceKeyGroupsGroupIdProfilePicPut(instanceKey, groupId, instancesInstanceKeyGroupsGroupIdProfilePicPutRequest);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGroupsInviteInfoGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGroupsInviteInfoGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //string inviteLink = null;
            //var response = instance.InstancesInstanceKeyGroupsInviteInfoGet(instanceKey, inviteLink);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
    }

}
