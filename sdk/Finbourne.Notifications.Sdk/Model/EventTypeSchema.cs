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
    /// An EventType object
    /// </summary>
    [DataContract(Name = "EventTypeSchema")]
    public partial class EventTypeSchema : IEquatable<EventTypeSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventTypeSchema" /> class.
        /// </summary>
        /// <param name="id">The identifier of the event type.</param>
        /// <param name="displayName">Identifier name of the event.</param>
        /// <param name="description">The summary of the event.</param>
        /// <param name="application">The application associated with the event.</param>
        /// <param name="href">A URI for retrieving this schema.</param>
        public EventTypeSchema(string id = default(string), string displayName = default(string), string description = default(string), string application = default(string), string href = default(string))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Description = description;
            this.Application = application;
            this.Href = href;
        }

        /// <summary>
        /// The identifier of the event type
        /// </summary>
        /// <value>The identifier of the event type</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier name of the event
        /// </summary>
        /// <value>Identifier name of the event</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The summary of the event
        /// </summary>
        /// <value>The summary of the event</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The application associated with the event
        /// </summary>
        /// <value>The application associated with the event</value>
        [DataMember(Name = "application", EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// The header schema for the event type
        /// </summary>
        /// <value>The header schema for the event type</value>
        [DataMember(Name = "headerSchema", EmitDefaultValue = true)]
        public List<EventFieldDefinition> HeaderSchema { get; private set; }

        /// <summary>
        /// Returns false as HeaderSchema should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHeaderSchema()
        {
            return false;
        }
        /// <summary>
        /// The body schema for the event type
        /// </summary>
        /// <value>The body schema for the event type</value>
        [DataMember(Name = "bodySchema", EmitDefaultValue = true)]
        public List<EventFieldDefinition> BodySchema { get; private set; }

        /// <summary>
        /// Returns false as BodySchema should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBodySchema()
        {
            return false;
        }
        /// <summary>
        /// A URI for retrieving this schema
        /// </summary>
        /// <value>A URI for retrieving this schema</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventTypeSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  HeaderSchema: ").Append(HeaderSchema).Append("\n");
            sb.Append("  BodySchema: ").Append(BodySchema).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(input as EventTypeSchema);
        }

        /// <summary>
        /// Returns true if EventTypeSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of EventTypeSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventTypeSchema input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.HeaderSchema == input.HeaderSchema ||
                    this.HeaderSchema != null &&
                    input.HeaderSchema != null &&
                    this.HeaderSchema.SequenceEqual(input.HeaderSchema)
                ) && 
                (
                    this.BodySchema == input.BodySchema ||
                    this.BodySchema != null &&
                    input.BodySchema != null &&
                    this.BodySchema.SequenceEqual(input.BodySchema)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Application != null)
                {
                    hashCode = (hashCode * 59) + this.Application.GetHashCode();
                }
                if (this.HeaderSchema != null)
                {
                    hashCode = (hashCode * 59) + this.HeaderSchema.GetHashCode();
                }
                if (this.BodySchema != null)
                {
                    hashCode = (hashCode * 59) + this.BodySchema.GetHashCode();
                }
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
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