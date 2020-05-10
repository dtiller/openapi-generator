/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnotherFakeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags and operation ID starting with number
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>ModelClient</returns>
        ModelClient Call123TestSpecialTags (ModelClient modelClient);

        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags and operation ID starting with number
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> Call123TestSpecialTagsWithHttpInfo (ModelClient modelClient);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags and operation ID starting with number
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>Task of ModelClient</returns>
        System.Threading.Tasks.Task<ModelClient> Call123TestSpecialTagsAsync (ModelClient modelClient);

        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags and operation ID starting with number
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> Call123TestSpecialTagsAsyncWithHttpInfo (ModelClient modelClient);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnotherFakeApi : IAnotherFakeApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherFakeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnotherFakeApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherFakeApi"/> class
        /// </summary>
        /// <returns></returns>
        public AnotherFakeApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherFakeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnotherFakeApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
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
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        /// To test special tags To test special tags and operation ID starting with number
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>ModelClient</returns>
        public ModelClient Call123TestSpecialTags (ModelClient modelClient)
        {
             ApiResponse<ModelClient> localVarResponse = Call123TestSpecialTagsWithHttpInfo(modelClient);
             return localVarResponse.Data;
        }

        /// <summary>
        /// To test special tags To test special tags and operation ID starting with number
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse<ModelClient> Call123TestSpecialTagsWithHttpInfo (ModelClient modelClient)
        {
            // verify the required parameter 'modelClient' is set
            if (modelClient == null)
                throw new ApiException(400, "Missing required parameter 'modelClient' when calling AnotherFakeApi->Call123TestSpecialTags");

            var localVarPath = "/another-fake/dummy";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (modelClient != null && modelClient.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(modelClient); // http body (model) parameter
            }
            else
            {
                localVarPostBody = modelClient; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Call123TestSpecialTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// To test special tags To test special tags and operation ID starting with number
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> Call123TestSpecialTagsAsync (ModelClient modelClient)
        {
             ApiResponse<ModelClient> localVarResponse = await Call123TestSpecialTagsAsyncWithHttpInfo(modelClient);
             return localVarResponse.Data;

        }

        /// <summary>
        /// To test special tags To test special tags and operation ID starting with number
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> Call123TestSpecialTagsAsyncWithHttpInfo (ModelClient modelClient)
        {
            // verify the required parameter 'modelClient' is set
            if (modelClient == null)
                throw new ApiException(400, "Missing required parameter 'modelClient' when calling AnotherFakeApi->Call123TestSpecialTags");

            var localVarPath = "/another-fake/dummy";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (modelClient != null && modelClient.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(modelClient); // http body (model) parameter
            }
            else
            {
                localVarPostBody = modelClient; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Call123TestSpecialTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

    }
}
