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
    /// Holds readonly information about an Azure Service Bus notification
    /// </summary>
    [DataContract(Name = "AzureServiceBusTypeResponse")]
    public partial class AzureServiceBusTypeResponse : IEquatable<AzureServiceBusTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AzureServiceBus for value: AzureServiceBus
            /// </summary>
            [EnumMember(Value = "AzureServiceBus")]
            AzureServiceBus = 1
        }


        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureServiceBusTypeResponse" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification.</param>
        /// <param name="namespaceRef">Reference to namespace from Configuration Store.</param>
        /// <param name="queueNameRef">Reference to queue name from Configuration Store.</param>
        /// <param name="body">The body of the Azure service bus Message.</param>
        /// <param name="tenantIdRef">Reference to tenant id  from Configuration Store.</param>
        /// <param name="clientIdRef">Reference to client id from Configuration Store.</param>
        /// <param name="clientSecretRef">Reference to client secret from Configuration Store.</param>
        public AzureServiceBusTypeResponse(TypeEnum ?type = default(TypeEnum?), string namespaceRef = default(string), string queueNameRef = default(string), string body = default(string), string tenantIdRef = default(string), string clientIdRef = default(string), string clientSecretRef = default(string))
        {
            this.Type = type;
            this.NamespaceRef = namespaceRef;
            this.QueueNameRef = queueNameRef;
            this.Body = body;
            this.TenantIdRef = tenantIdRef;
            this.ClientIdRef = clientIdRef;
            this.ClientSecretRef = clientSecretRef;
        }

        /// <summary>
        /// Reference to namespace from Configuration Store
        /// </summary>
        /// <value>Reference to namespace from Configuration Store</value>
        [DataMember(Name = "namespaceRef", EmitDefaultValue = true)]
        public string NamespaceRef { get; set; }

        /// <summary>
        /// Reference to queue name from Configuration Store
        /// </summary>
        /// <value>Reference to queue name from Configuration Store</value>
        [DataMember(Name = "queueNameRef", EmitDefaultValue = true)]
        public string QueueNameRef { get; set; }

        /// <summary>
        /// The body of the Azure service bus Message
        /// </summary>
        /// <value>The body of the Azure service bus Message</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Reference to tenant id  from Configuration Store
        /// </summary>
        /// <value>Reference to tenant id  from Configuration Store</value>
        [DataMember(Name = "tenantIdRef", EmitDefaultValue = true)]
        public string TenantIdRef { get; set; }

        /// <summary>
        /// Reference to client id from Configuration Store
        /// </summary>
        /// <value>Reference to client id from Configuration Store</value>
        [DataMember(Name = "clientIdRef", EmitDefaultValue = true)]
        public string ClientIdRef { get; set; }

        /// <summary>
        /// Reference to client secret from Configuration Store
        /// </summary>
        /// <value>Reference to client secret from Configuration Store</value>
        [DataMember(Name = "clientSecretRef", EmitDefaultValue = true)]
        public string ClientSecretRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureServiceBusTypeResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NamespaceRef: ").Append(NamespaceRef).Append("\n");
            sb.Append("  QueueNameRef: ").Append(QueueNameRef).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  TenantIdRef: ").Append(TenantIdRef).Append("\n");
            sb.Append("  ClientIdRef: ").Append(ClientIdRef).Append("\n");
            sb.Append("  ClientSecretRef: ").Append(ClientSecretRef).Append("\n");
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
            return this.Equals(input as AzureServiceBusTypeResponse);
        }

        /// <summary>
        /// Returns true if AzureServiceBusTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureServiceBusTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureServiceBusTypeResponse input)
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
                    this.NamespaceRef == input.NamespaceRef ||
                    (this.NamespaceRef != null &&
                    this.NamespaceRef.Equals(input.NamespaceRef))
                ) && 
                (
                    this.QueueNameRef == input.QueueNameRef ||
                    (this.QueueNameRef != null &&
                    this.QueueNameRef.Equals(input.QueueNameRef))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.TenantIdRef == input.TenantIdRef ||
                    (this.TenantIdRef != null &&
                    this.TenantIdRef.Equals(input.TenantIdRef))
                ) && 
                (
                    this.ClientIdRef == input.ClientIdRef ||
                    (this.ClientIdRef != null &&
                    this.ClientIdRef.Equals(input.ClientIdRef))
                ) && 
                (
                    this.ClientSecretRef == input.ClientSecretRef ||
                    (this.ClientSecretRef != null &&
                    this.ClientSecretRef.Equals(input.ClientSecretRef))
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
                if (this.NamespaceRef != null)
                {
                    hashCode = (hashCode * 59) + this.NamespaceRef.GetHashCode();
                }
                if (this.QueueNameRef != null)
                {
                    hashCode = (hashCode * 59) + this.QueueNameRef.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.TenantIdRef != null)
                {
                    hashCode = (hashCode * 59) + this.TenantIdRef.GetHashCode();
                }
                if (this.ClientIdRef != null)
                {
                    hashCode = (hashCode * 59) + this.ClientIdRef.GetHashCode();
                }
                if (this.ClientSecretRef != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecretRef.GetHashCode();
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
