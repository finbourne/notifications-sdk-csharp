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
    /// Holds readonly information about an Email notification
    /// </summary>
    [DataContract(Name = "EmailNotificationTypeResponse")]
    public partial class EmailNotificationTypeResponse : IEquatable<EmailNotificationTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailNotificationTypeResponse" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="plainTextBody">The plain text body of the email.</param>
        /// <param name="htmlBody">The HTML body of the email (if any).</param>
        /// <param name="emailAddressTo">&#39;To&#39; recipients of the email.</param>
        /// <param name="emailAddressCc">&#39;Cc&#39; recipients of the email.</param>
        /// <param name="emailAddressBcc">&#39;Bcc&#39; recipients of the email.</param>
        public EmailNotificationTypeResponse(string type = default(string), string subject = default(string), string plainTextBody = default(string), string htmlBody = default(string), List<string> emailAddressTo = default(List<string>), List<string> emailAddressCc = default(List<string>), List<string> emailAddressBcc = default(List<string>))
        {
            this.Type = type;
            this.Subject = subject;
            this.PlainTextBody = plainTextBody;
            this.HtmlBody = htmlBody;
            this.EmailAddressTo = emailAddressTo;
            this.EmailAddressCc = emailAddressCc;
            this.EmailAddressBcc = emailAddressBcc;
        }

        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The subject of the email
        /// </summary>
        /// <value>The subject of the email</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// The plain text body of the email
        /// </summary>
        /// <value>The plain text body of the email</value>
        [DataMember(Name = "plainTextBody", EmitDefaultValue = true)]
        public string PlainTextBody { get; set; }

        /// <summary>
        /// The HTML body of the email (if any)
        /// </summary>
        /// <value>The HTML body of the email (if any)</value>
        [DataMember(Name = "htmlBody", EmitDefaultValue = true)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// &#39;To&#39; recipients of the email
        /// </summary>
        /// <value>&#39;To&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressTo", EmitDefaultValue = true)]
        public List<string> EmailAddressTo { get; set; }

        /// <summary>
        /// &#39;Cc&#39; recipients of the email
        /// </summary>
        /// <value>&#39;Cc&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressCc", EmitDefaultValue = true)]
        public List<string> EmailAddressCc { get; set; }

        /// <summary>
        /// &#39;Bcc&#39; recipients of the email
        /// </summary>
        /// <value>&#39;Bcc&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressBcc", EmitDefaultValue = true)]
        public List<string> EmailAddressBcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailNotificationTypeResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  PlainTextBody: ").Append(PlainTextBody).Append("\n");
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
            sb.Append("  EmailAddressTo: ").Append(EmailAddressTo).Append("\n");
            sb.Append("  EmailAddressCc: ").Append(EmailAddressCc).Append("\n");
            sb.Append("  EmailAddressBcc: ").Append(EmailAddressBcc).Append("\n");
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
            return this.Equals(input as EmailNotificationTypeResponse);
        }

        /// <summary>
        /// Returns true if EmailNotificationTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailNotificationTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailNotificationTypeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.PlainTextBody == input.PlainTextBody ||
                    (this.PlainTextBody != null &&
                    this.PlainTextBody.Equals(input.PlainTextBody))
                ) && 
                (
                    this.HtmlBody == input.HtmlBody ||
                    (this.HtmlBody != null &&
                    this.HtmlBody.Equals(input.HtmlBody))
                ) && 
                (
                    this.EmailAddressTo == input.EmailAddressTo ||
                    this.EmailAddressTo != null &&
                    input.EmailAddressTo != null &&
                    this.EmailAddressTo.SequenceEqual(input.EmailAddressTo)
                ) && 
                (
                    this.EmailAddressCc == input.EmailAddressCc ||
                    this.EmailAddressCc != null &&
                    input.EmailAddressCc != null &&
                    this.EmailAddressCc.SequenceEqual(input.EmailAddressCc)
                ) && 
                (
                    this.EmailAddressBcc == input.EmailAddressBcc ||
                    this.EmailAddressBcc != null &&
                    input.EmailAddressBcc != null &&
                    this.EmailAddressBcc.SequenceEqual(input.EmailAddressBcc)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.PlainTextBody != null)
                {
                    hashCode = (hashCode * 59) + this.PlainTextBody.GetHashCode();
                }
                if (this.HtmlBody != null)
                {
                    hashCode = (hashCode * 59) + this.HtmlBody.GetHashCode();
                }
                if (this.EmailAddressTo != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddressTo.GetHashCode();
                }
                if (this.EmailAddressCc != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddressCc.GetHashCode();
                }
                if (this.EmailAddressBcc != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddressBcc.GetHashCode();
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
