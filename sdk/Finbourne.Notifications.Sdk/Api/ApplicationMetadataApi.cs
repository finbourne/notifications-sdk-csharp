/*
 * FINBOURNE Notifications API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Object = System.Object;
using InvalidOperationException = System.InvalidOperationException;
using Exception = System.Exception;
using ArgumentNullException = System.ArgumentNullException;
using SystemEventHandler = System.EventHandler;
using DateTimeOffset = System.DateTimeOffset;
using Guid = System.Guid;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using IApiAccessor = Finbourne.Notifications.Sdk.Client.IApiAccessor;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Client.Auth;
using Finbourne.Notifications.Sdk.Model;

namespace Finbourne.Notifications.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ResourceListOfAccessControlledResource</returns>
        ResourceListOfAccessControlledResource ListAccessControlledResources(int operationIndex = 0, ConfigurationOptions? opts = null);

        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ApiResponse of ResourceListOfAccessControlledResource</returns>
        Finbourne.Notifications.Sdk.Client.ApiResponse<ResourceListOfAccessControlledResource> ListAccessControlledResourcesWithHttpInfo(int operationIndex = 0, ConfigurationOptions? opts = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ResourceListOfAccessControlledResource</returns>
        System.Threading.Tasks.Task<ResourceListOfAccessControlledResource> ListAccessControlledResourcesAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null);

        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessControlledResource)</returns>
        System.Threading.Tasks.Task<Finbourne.Notifications.Sdk.Client.ApiResponse<ResourceListOfAccessControlledResource>> ListAccessControlledResourcesWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationMetadataApi : IApplicationMetadataApiSync, IApplicationMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationMetadataApi : IApplicationMetadataApi
    {
        private Finbourne.Notifications.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationMetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationMetadataApi(string basePath)
        {
            var globalConfiguration = Finbourne.Notifications.Sdk.Client.GlobalConfiguration.Instance;
            this.Configuration = Finbourne.Notifications.Sdk.Client.Configuration.MergeConfigurations(
                globalConfiguration,
                new Finbourne.Notifications.Sdk.Client.Configuration
                {
                    BasePath = basePath,
                    TimeoutMs = globalConfiguration.TimeoutMs,
                    RateLimitRetries = globalConfiguration.RateLimitRetries
                }
            );
            this.Client = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Notifications.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationMetadataApi(Finbourne.Notifications.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Notifications.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ApplicationMetadataApi(Finbourne.Notifications.Sdk.Client.ISynchronousClient client, Finbourne.Notifications.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Notifications.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Notifications.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Notifications.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Notifications.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Finbourne.Notifications.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Notifications.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ResourceListOfAccessControlledResource</returns>
        public ResourceListOfAccessControlledResource ListAccessControlledResources(int operationIndex = 0, ConfigurationOptions? opts = null)
        {
            Finbourne.Notifications.Sdk.Client.ApiResponse<ResourceListOfAccessControlledResource> localVarResponse = ListAccessControlledResourcesWithHttpInfo(opts: opts);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ApiResponse of ResourceListOfAccessControlledResource</returns>
        public Finbourne.Notifications.Sdk.Client.ApiResponse<ResourceListOfAccessControlledResource> ListAccessControlledResourcesWithHttpInfo(int operationIndex = 0, ConfigurationOptions? opts = null)
        {
            Finbourne.Notifications.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Notifications.Sdk.Client.RequestOptions();

            if (opts is { TimeoutMs: not null })
            {
                localVarRequestOptions.TimeoutMs = opts.TimeoutMs.Value;
            }
            
            if (opts is { RateLimitRetries: not null })
            {
                localVarRequestOptions.RateLimitRetries = opts.RateLimitRetries.Value;
            }

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "ApplicationMetadataApi.ListAccessControlledResources";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfAccessControlledResource>("/api/metadata/access/resources", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAccessControlledResources", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ResourceListOfAccessControlledResource</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAccessControlledResource> ListAccessControlledResourcesAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null)
        {
            Finbourne.Notifications.Sdk.Client.ApiResponse<ResourceListOfAccessControlledResource> localVarResponse = await ListAccessControlledResourcesWithHttpInfoAsync(operationIndex, cancellationToken, opts).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListAccessControlledResources: Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessControlledResource)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Notifications.Sdk.Client.ApiResponse<ResourceListOfAccessControlledResource>> ListAccessControlledResourcesWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null)
        {

            Finbourne.Notifications.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Notifications.Sdk.Client.RequestOptions();

            if (opts is { TimeoutMs: not null })
            {
                localVarRequestOptions.TimeoutMs = opts.TimeoutMs.Value;
            }
            
            if (opts is { RateLimitRetries: not null })
            {
                localVarRequestOptions.RateLimitRetries = opts.RateLimitRetries.Value;
            }

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "ApplicationMetadataApi.ListAccessControlledResources";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfAccessControlledResource>("/api/metadata/access/resources", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAccessControlledResources", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}