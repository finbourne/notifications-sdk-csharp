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
    /// A matching pattern object
    /// </summary>
    [DataContract(Name = "MatchingPattern")]
    public partial class MatchingPattern : IEquatable<MatchingPattern>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingPattern" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchingPattern() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingPattern" /> class.
        /// </summary>
        /// <param name="eventType">The type of event to subscribe to. The list of available event types can be discovered  by calling the ‘List available EventTypes’ API endpoint. (required).</param>
        /// <param name="filter">A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched.</param>
        public MatchingPattern(string eventType = default(string), string filter = default(string))
        {
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new ArgumentNullException("eventType is a required property for MatchingPattern and cannot be null");
            }
            this.EventType = eventType;
            this.Filter = filter;
        }

        /// <summary>
        /// The type of event to subscribe to. The list of available event types can be discovered  by calling the ‘List available EventTypes’ API endpoint.
        /// </summary>
        /// <value>The type of event to subscribe to. The list of available event types can be discovered  by calling the ‘List available EventTypes’ API endpoint.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched
        /// </summary>
        /// <value>A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched</value>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchingPattern {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(input as MatchingPattern);
        }

        /// <summary>
        /// Returns true if MatchingPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchingPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchingPattern input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
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
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
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
            // EventType (string) maxLength
            if (this.EventType != null && this.EventType.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be less than 512.", new [] { "EventType" });
            }

            // EventType (string) minLength
            if (this.EventType != null && this.EventType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be greater than 0.", new [] { "EventType" });
            }

            // EventType (string) pattern
            Regex regexEventType = new Regex(@"^[a-zA-Z]*$", RegexOptions.CultureInvariant);
            if (false == regexEventType.Match(this.EventType).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, must match a pattern of " + regexEventType, new [] { "EventType" });
            }

            // Filter (string) maxLength
            if (this.Filter != null && this.Filter.Length > 16384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, length must be less than 16384.", new [] { "Filter" });
            }

            // Filter (string) minLength
            if (this.Filter != null && this.Filter.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, length must be greater than 0.", new [] { "Filter" });
            }

            // Filter (string) pattern
            Regex regexFilter = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexFilter.Match(this.Filter).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, must match a pattern of " + regexFilter, new [] { "Filter" });
            }

            yield break;
        }
    }
}