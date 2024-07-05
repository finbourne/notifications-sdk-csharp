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
    /// Holds readonly information about an AWS SQS notification
    /// </summary>
    [DataContract(Name = "AmazonSqsNotificationTypeResponse")]
    public partial class AmazonSqsNotificationTypeResponse : IEquatable<AmazonSqsNotificationTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AmazonSqs for value: AmazonSqs
            /// </summary>
            [EnumMember(Value = "AmazonSqs")]
            AmazonSqs = 1

        }


        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonSqsNotificationTypeResponse" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification.</param>
        /// <param name="apiKeyRef">Reference to API key from Configuration Store.</param>
        /// <param name="apiSecretRef">Reference to API secret from Configuration Store.</param>
        /// <param name="body">The body of the Amazon Queue Message.</param>
        /// <param name="queueUrlRef">Reference to queue url from Configuration Store.</param>
        public AmazonSqsNotificationTypeResponse(TypeEnum? type = default(TypeEnum?), string apiKeyRef = default(string), string apiSecretRef = default(string), string body = default(string), string queueUrlRef = default(string))
        {
            this.Type = type;
            this.ApiKeyRef = apiKeyRef;
            this.ApiSecretRef = apiSecretRef;
            this.Body = body;
            this.QueueUrlRef = queueUrlRef;
        }

        /// <summary>
        /// Reference to API key from Configuration Store
        /// </summary>
        /// <value>Reference to API key from Configuration Store</value>
        [DataMember(Name = "apiKeyRef", EmitDefaultValue = true)]
        public string ApiKeyRef { get; set; }

        /// <summary>
        /// Reference to API secret from Configuration Store
        /// </summary>
        /// <value>Reference to API secret from Configuration Store</value>
        [DataMember(Name = "apiSecretRef", EmitDefaultValue = true)]
        public string ApiSecretRef { get; set; }

        /// <summary>
        /// The body of the Amazon Queue Message
        /// </summary>
        /// <value>The body of the Amazon Queue Message</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Reference to queue url from Configuration Store
        /// </summary>
        /// <value>Reference to queue url from Configuration Store</value>
        [DataMember(Name = "queueUrlRef", EmitDefaultValue = true)]
        public string QueueUrlRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AmazonSqsNotificationTypeResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ApiKeyRef: ").Append(ApiKeyRef).Append("\n");
            sb.Append("  ApiSecretRef: ").Append(ApiSecretRef).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  QueueUrlRef: ").Append(QueueUrlRef).Append("\n");
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
            return this.Equals(input as AmazonSqsNotificationTypeResponse);
        }

        /// <summary>
        /// Returns true if AmazonSqsNotificationTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AmazonSqsNotificationTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonSqsNotificationTypeResponse input)
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
                    this.ApiKeyRef == input.ApiKeyRef ||
                    (this.ApiKeyRef != null &&
                    this.ApiKeyRef.Equals(input.ApiKeyRef))
                ) && 
                (
                    this.ApiSecretRef == input.ApiSecretRef ||
                    (this.ApiSecretRef != null &&
                    this.ApiSecretRef.Equals(input.ApiSecretRef))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.QueueUrlRef == input.QueueUrlRef ||
                    (this.QueueUrlRef != null &&
                    this.QueueUrlRef.Equals(input.QueueUrlRef))
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
                if (this.ApiKeyRef != null)
                {
                    hashCode = (hashCode * 59) + this.ApiKeyRef.GetHashCode();
                }
                if (this.ApiSecretRef != null)
                {
                    hashCode = (hashCode * 59) + this.ApiSecretRef.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.QueueUrlRef != null)
                {
                    hashCode = (hashCode * 59) + this.QueueUrlRef.GetHashCode();
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
