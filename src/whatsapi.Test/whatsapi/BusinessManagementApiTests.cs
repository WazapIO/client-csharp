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
    ///  Class for testing BusinessManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BusinessManagementApiTests
    {
        private BusinessManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BusinessManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BusinessManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' BusinessManagementApi
            //Assert.IsInstanceOf(typeof(BusinessManagementApi), instance);
        }

        
        /// <summary>
        /// Test InstancesInstanceKeyBusinessCatalogGet
        /// </summary>
        [Test]
        public void InstancesInstanceKeyBusinessCatalogGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceKey = null;
            //var response = instance.InstancesInstanceKeyBusinessCatalogGet(instanceKey);
            //Assert.IsInstanceOf(typeof(APIResponse), response, "response is APIResponse");
        }
        
    }

}