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
    /// The information required to create or update an SMS notification
    /// </summary>
    [DataContract(Name = "SmsNotificationType")]
    public partial class SmsNotificationType : IEquatable<SmsNotificationType>, IValidatableObject
    {
        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sms for value: Sms
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms = 1

        }


        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNotificationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsNotificationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNotificationType" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification (required).</param>
        /// <param name="body">The body of the SMS (required).</param>
        /// <param name="recipients">The phone numbers to which the SMS will be sent to (E.164 format) (required).</param>
        public SmsNotificationType(TypeEnum type = default(TypeEnum), string body = default(string), List<string> recipients = default(List<string>))
        {
            this.Type = type;
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for SmsNotificationType and cannot be null");
            }
            this.Body = body;
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for SmsNotificationType and cannot be null");
            }
            this.Recipients = recipients;
        }

        /// <summary>
        /// The body of the SMS
        /// </summary>
        /// <value>The body of the SMS</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// The phone numbers to which the SMS will be sent to (E.164 format)
        /// </summary>
        /// <value>The phone numbers to which the SMS will be sent to (E.164 format)</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmsNotificationType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
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
            return this.Equals(input as SmsNotificationType);
        }

        /// <summary>
        /// Returns true if SmsNotificationType instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsNotificationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsNotificationType input)
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
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
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
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
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
            // Body (string) maxLength
            if (this.Body != null && this.Body.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Body, length must be less than 1024.", new [] { "Body" });
            }

            // Body (string) minLength
            if (this.Body != null && this.Body.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Body, length must be greater than 1.", new [] { "Body" });
            }

            // Body (string) pattern
            Regex regexBody = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexBody.Match(this.Body).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Body, must match a pattern of " + regexBody, new [] { "Body" });
            }

            yield break;
        }
    }
}
