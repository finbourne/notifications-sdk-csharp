/*
 * FINBOURNE Notifications API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Notifications.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// Holds readonly information about a Webhook notification
    /// </summary>
    [DataContract(Name = "WebhookNotificationTypeResponse")]
    public partial class WebhookNotificationTypeResponse : IEquatable<WebhookNotificationTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Webhook for value: Webhook
            /// </summary>
            [EnumMember(Value = "Webhook")]
            Webhook = 1
        }


        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNotificationTypeResponse" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification.</param>
        /// <param name="httpMethod">The HTTP method such as GET, POST, etc. to use on the request.</param>
        /// <param name="url">The URL to send the request to.</param>
        /// <param name="authenticationType">The type of authentication to use on the request.</param>
        /// <param name="authenticationConfigurationItemPaths">The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }.</param>
        /// <param name="contentType">The type of the content e.g. Json.</param>
        /// <param name="content">The content of the request.</param>
        public WebhookNotificationTypeResponse(TypeEnum? type = default(TypeEnum?), string httpMethod = default(string), string url = default(string), string authenticationType = default(string), Dictionary<string, string> authenticationConfigurationItemPaths = default(Dictionary<string, string>), string contentType = default(string), Object content = default(Object))
        {
            this.Type = type;
            this.HttpMethod = httpMethod;
            this.Url = url;
            this.AuthenticationType = authenticationType;
            this.AuthenticationConfigurationItemPaths = authenticationConfigurationItemPaths;
            this.ContentType = contentType;
            this.Content = content;
        }

        /// <summary>
        /// The HTTP method such as GET, POST, etc. to use on the request
        /// </summary>
        /// <value>The HTTP method such as GET, POST, etc. to use on the request</value>
        [DataMember(Name = "httpMethod", EmitDefaultValue = true)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The URL to send the request to
        /// </summary>
        /// <value>The URL to send the request to</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The type of authentication to use on the request
        /// </summary>
        /// <value>The type of authentication to use on the request</value>
        [DataMember(Name = "authenticationType", EmitDefaultValue = true)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }
        /// </summary>
        /// <value>The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }</value>
        [DataMember(Name = "authenticationConfigurationItemPaths", EmitDefaultValue = true)]
        public Dictionary<string, string> AuthenticationConfigurationItemPaths { get; set; }

        /// <summary>
        /// The type of the content e.g. Json
        /// </summary>
        /// <value>The type of the content e.g. Json</value>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// The content of the request
        /// </summary>
        /// <value>The content of the request</value>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public Object Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookNotificationTypeResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  AuthenticationConfigurationItemPaths: ").Append(AuthenticationConfigurationItemPaths).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookNotificationTypeResponse);
        }

        /// <summary>
        /// Returns true if WebhookNotificationTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookNotificationTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookNotificationTypeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
                ) && 
                (
                    this.AuthenticationConfigurationItemPaths == input.AuthenticationConfigurationItemPaths ||
                    this.AuthenticationConfigurationItemPaths != null &&
                    input.AuthenticationConfigurationItemPaths != null &&
                    this.AuthenticationConfigurationItemPaths.SequenceEqual(input.AuthenticationConfigurationItemPaths)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.HttpMethod != null)
                {
                    hashCode = (hashCode * 59) + this.HttpMethod.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.AuthenticationType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationType.GetHashCode();
                }
                if (this.AuthenticationConfigurationItemPaths != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationConfigurationItemPaths.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
