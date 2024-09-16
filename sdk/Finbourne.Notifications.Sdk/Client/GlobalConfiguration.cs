/*
 * FINBOURNE Notifications API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.Collections.Generic;
using Finbourne.Notifications.Sdk.Extensions;

namespace Finbourne.Notifications.Sdk.Client
{
    /// <summary>
    /// <see cref="GlobalConfiguration"/> provides a compile-time extension point for globally configuring
    /// API Clients.
    /// </summary>
    /// <remarks>
    /// A customized implementation via partial class may reside in another file and may
    /// be excluded from automatic generation via a .openapi-generator-ignore file.
    /// </remarks>
    public partial class GlobalConfiguration : Configuration
    {
        #region Private Members

        private static readonly object GlobalConfigSync = new { };
        private static IReadableConfiguration? _globalConfiguration;

        #endregion Private Members

        #region Constructors

        /// <inheritdoc />
        private GlobalConfiguration()
        {
        }

        /// <inheritdoc />
        public GlobalConfiguration(IDictionary<string, string> defaultHeader, IDictionary<string, string> apiKey, IDictionary<string, string> apiKeyPrefix, string basePath = "http://localhost:3000/api") : base(defaultHeader, apiKey, apiKeyPrefix, basePath)
        {
        }

        #endregion Constructors

        /// <summary>
        /// Set the static instance to the default global configuration
        /// </summary>
        public static void SetDefaultInstance()
        {
            var globalConfiguration = new GlobalConfiguration();
            globalConfiguration.DefaultHeaders.Add("X-LUSID-Sdk-Language", "C#");
            globalConfiguration.DefaultHeaders.Add("X-LUSID-Sdk-Version", Version);
            Instance = globalConfiguration;
        }

        /// <summary>
        /// Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static IReadableConfiguration Instance
        {
            get
            {
                if (_globalConfiguration == null)
                {
                    SetDefaultInstance();
                }
                return _globalConfiguration!;
            }
            set
            {
                lock (GlobalConfigSync)
                {
                    _globalConfiguration = value;
                }
            }
        }
    }
}