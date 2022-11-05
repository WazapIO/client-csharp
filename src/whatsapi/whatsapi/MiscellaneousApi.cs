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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using WhatsAPI.Client;
using WhatsAPI.models;

namespace WhatsAPI.whatsapi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMiscellaneousApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get profile pic.
        /// </summary>
        /// <remarks>
        /// Returns the profile pic of the given user.
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <returns>APIResponse</returns>
        APIResponse GetProfilePic (string instanceKey, string jid);

        /// <summary>
        /// Get profile pic.
        /// </summary>
        /// <remarks>
        /// Returns the profile pic of the given user.
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <returns>ApiResponse of APIResponse</returns>
        ApiResponse<APIResponse> GetProfilePicWithHttpInfo (string instanceKey, string jid);
        /// <summary>
        /// Fetches the users info.
        /// </summary>
        /// <remarks>
        /// Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <returns>APIResponse</returns>
        APIResponse GetUsersInfo (string instanceKey, UserInfoPayload data);

        /// <summary>
        /// Fetches the users info.
        /// </summary>
        /// <remarks>
        /// Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <returns>ApiResponse of APIResponse</returns>
        ApiResponse<APIResponse> GetUsersInfoWithHttpInfo (string instanceKey, UserInfoPayload data);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get profile pic.
        /// </summary>
        /// <remarks>
        /// Returns the profile pic of the given user.
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of APIResponse</returns>
        System.Threading.Tasks.Task<APIResponse> GetProfilePicAsync (string instanceKey, string jid, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get profile pic.
        /// </summary>
        /// <remarks>
        /// Returns the profile pic of the given user.
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (APIResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<APIResponse>> GetProfilePicWithHttpInfoAsync (string instanceKey, string jid, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Fetches the users info.
        /// </summary>
        /// <remarks>
        /// Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of APIResponse</returns>
        System.Threading.Tasks.Task<APIResponse> GetUsersInfoAsync (string instanceKey, UserInfoPayload data, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Fetches the users info.
        /// </summary>
        /// <remarks>
        /// Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </remarks>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (APIResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<APIResponse>> GetUsersInfoWithHttpInfoAsync (string instanceKey, UserInfoPayload data, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MiscellaneousApi : IMiscellaneousApi
    {
        private WhatsAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscellaneousApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MiscellaneousApi(String basePath)
        {
            this.Configuration = new WhatsAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = WhatsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscellaneousApi"/> class
        /// </summary>
        /// <returns></returns>
        public MiscellaneousApi()
        {
            this.Configuration = WhatsAPI.Client.Configuration.Default;

            ExceptionFactory = WhatsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscellaneousApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MiscellaneousApi(WhatsAPI.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = WhatsAPI.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = WhatsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public WhatsAPI.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public WhatsAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get profile pic. Returns the profile pic of the given user.
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <returns>APIResponse</returns>
        public APIResponse GetProfilePic (string instanceKey, string jid)
        {
             ApiResponse<APIResponse> localVarResponse = GetProfilePicWithHttpInfo(instanceKey, jid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get profile pic. Returns the profile pic of the given user.
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <returns>ApiResponse of APIResponse</returns>
        public ApiResponse<APIResponse> GetProfilePicWithHttpInfo (string instanceKey, string jid)
        {
            // verify the required parameter 'instanceKey' is set
            if (instanceKey == null)
                throw new ApiException(400, "Missing required parameter 'instanceKey' when calling MiscellaneousApi->GetProfilePic");
            // verify the required parameter 'jid' is set
            if (jid == null)
                throw new ApiException(400, "Missing required parameter 'jid' when calling MiscellaneousApi->GetProfilePic");

            var localVarPath = "/instances/{instance_key}/misc/profile-pic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (instanceKey != null) localVarPathParams.Add("instance_key", this.Configuration.ApiClient.ParameterToString(instanceKey)); // path parameter
            if (jid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "jid", jid)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProfilePic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<APIResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (APIResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIResponse)));
        }

        /// <summary>
        /// Get profile pic. Returns the profile pic of the given user.
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of APIResponse</returns>
        public async System.Threading.Tasks.Task<APIResponse> GetProfilePicAsync (string instanceKey, string jid, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<APIResponse> localVarResponse = await GetProfilePicWithHttpInfoAsync(instanceKey, jid, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get profile pic. Returns the profile pic of the given user.
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="jid">JID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (APIResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<APIResponse>> GetProfilePicWithHttpInfoAsync (string instanceKey, string jid, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'instanceKey' is set
            if (instanceKey == null)
                throw new ApiException(400, "Missing required parameter 'instanceKey' when calling MiscellaneousApi->GetProfilePic");
            // verify the required parameter 'jid' is set
            if (jid == null)
                throw new ApiException(400, "Missing required parameter 'jid' when calling MiscellaneousApi->GetProfilePic");

            var localVarPath = "/instances/{instance_key}/misc/profile-pic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (instanceKey != null) localVarPathParams.Add("instance_key", this.Configuration.ApiClient.ParameterToString(instanceKey)); // path parameter
            if (jid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "jid", jid)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProfilePic", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<APIResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (APIResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIResponse)));
        }

        /// <summary>
        /// Fetches the users info. Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <returns>APIResponse</returns>
        public APIResponse GetUsersInfo (string instanceKey, UserInfoPayload data)
        {
             ApiResponse<APIResponse> localVarResponse = GetUsersInfoWithHttpInfo(instanceKey, data);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetches the users info. Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <returns>ApiResponse of APIResponse</returns>
        public ApiResponse<APIResponse> GetUsersInfoWithHttpInfo (string instanceKey, UserInfoPayload data)
        {
            // verify the required parameter 'instanceKey' is set
            if (instanceKey == null)
                throw new ApiException(400, "Missing required parameter 'instanceKey' when calling MiscellaneousApi->GetUsersInfo");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling MiscellaneousApi->GetUsersInfo");

            var localVarPath = "/instances/{instance_key}/misc/user-info";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (instanceKey != null) localVarPathParams.Add("instance_key", this.Configuration.ApiClient.ParameterToString(instanceKey)); // path parameter
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsersInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<APIResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (APIResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIResponse)));
        }

        /// <summary>
        /// Fetches the users info. Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of APIResponse</returns>
        public async System.Threading.Tasks.Task<APIResponse> GetUsersInfoAsync (string instanceKey, UserInfoPayload data, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<APIResponse> localVarResponse = await GetUsersInfoWithHttpInfoAsync(instanceKey, data, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetches the users info. Gets the user info for the given user ids. This does not checks if user is registered or not
        /// </summary>
        /// <exception cref="WhatsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instanceKey">Instance key</param>
        /// <param name="data">Data</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (APIResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<APIResponse>> GetUsersInfoWithHttpInfoAsync (string instanceKey, UserInfoPayload data, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'instanceKey' is set
            if (instanceKey == null)
                throw new ApiException(400, "Missing required parameter 'instanceKey' when calling MiscellaneousApi->GetUsersInfo");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling MiscellaneousApi->GetUsersInfo");

            var localVarPath = "/instances/{instance_key}/misc/user-info";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (instanceKey != null) localVarPathParams.Add("instance_key", this.Configuration.ApiClient.ParameterToString(instanceKey)); // path parameter
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsersInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<APIResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (APIResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIResponse)));
        }

    }
}
