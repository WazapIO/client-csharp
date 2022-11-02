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

using WhatsAPI.Client;
using WhatsAPI.whatsapi;
using WhatsAPI.models;

namespace WhatsAPI.Test
{
    /// <summary>
    ///  Class for testing InstanceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InstanceApiTests
    {
        private InstanceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InstanceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InstanceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' InstanceApi
            //Assert.IsInstanceOf(typeof(InstanceApi), instance);
        }

        
        /// <summary>
        /// Test InstancesCreateGet
        /// </summary>
        [Test]
        public void InstancesCreateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesCreateGet(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyContactsGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyContactsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyContactsGet(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyDeleteDelete
        /// </summary>
        [Test]
        public void InstancesInstanceKeyDeleteDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyDeleteDelete(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyGet(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyLogoutDelete
        /// </summary>
        [Test]
        public void InstancesInstanceKeyLogoutDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyLogoutDelete(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyQrcodeGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyQrcodeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyQrcodeGet(instanceKey);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesInstanceKeyWebhookPut
        /// </summary>
        [Test]
        public void InstancesInstanceKeyWebhookPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //StructsWebhookPayload data = null;
            //var response = instance.InstancesInstanceKeyWebhookPut(instanceKey, data);
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
        /// <summary>
        /// Test InstancesListGet
        /// </summary>
        [Test]
        public void InstancesListGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.InstancesListGet();
            //Assert.IsInstanceOf(typeof(MainAPIResponse), response, "response is MainAPIResponse");
        }
        
    }

}