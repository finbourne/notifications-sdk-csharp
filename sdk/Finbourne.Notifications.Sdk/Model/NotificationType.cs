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
using System.Reflection;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// Holds information about a Finbourne.Notifications.WebApi.Dtos.Notifications.Notification that is being created
    /// </summary>
    [JsonConverter(typeof(NotificationTypeJsonConverter))]
    [DataContract(Name = "NotificationType")]
    public partial class NotificationType : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class
        /// with the <see cref="AmazonSqsNotificationType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AmazonSqsNotificationType.</param>
        public NotificationType(AmazonSqsNotificationType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class
        /// with the <see cref="AmazonSqsPrincipalAuthNotificationType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AmazonSqsPrincipalAuthNotificationType.</param>
        public NotificationType(AmazonSqsPrincipalAuthNotificationType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class
        /// with the <see cref="AzureServiceBusNotificationType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AzureServiceBusNotificationType.</param>
        public NotificationType(AzureServiceBusNotificationType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class
        /// with the <see cref="EmailNotificationType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EmailNotificationType.</param>
        public NotificationType(EmailNotificationType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class
        /// with the <see cref="SmsNotificationType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SmsNotificationType.</param>
        public NotificationType(SmsNotificationType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class
        /// with the <see cref="WebhookNotificationType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebhookNotificationType.</param>
        public NotificationType(WebhookNotificationType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AmazonSqsNotificationType) || value is AmazonSqsNotificationType)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AmazonSqsPrincipalAuthNotificationType) || value is AmazonSqsPrincipalAuthNotificationType)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AzureServiceBusNotificationType) || value is AzureServiceBusNotificationType)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EmailNotificationType) || value is EmailNotificationType)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SmsNotificationType) || value is SmsNotificationType)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebhookNotificationType) || value is WebhookNotificationType)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AmazonSqsNotificationType, AmazonSqsPrincipalAuthNotificationType, AzureServiceBusNotificationType, EmailNotificationType, SmsNotificationType, WebhookNotificationType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AmazonSqsNotificationType`. If the actual instance is not `AmazonSqsNotificationType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AmazonSqsNotificationType</returns>
        public AmazonSqsNotificationType GetAmazonSqsNotificationType()
        {
            return (AmazonSqsNotificationType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AmazonSqsPrincipalAuthNotificationType`. If the actual instance is not `AmazonSqsPrincipalAuthNotificationType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AmazonSqsPrincipalAuthNotificationType</returns>
        public AmazonSqsPrincipalAuthNotificationType GetAmazonSqsPrincipalAuthNotificationType()
        {
            return (AmazonSqsPrincipalAuthNotificationType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AzureServiceBusNotificationType`. If the actual instance is not `AzureServiceBusNotificationType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AzureServiceBusNotificationType</returns>
        public AzureServiceBusNotificationType GetAzureServiceBusNotificationType()
        {
            return (AzureServiceBusNotificationType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EmailNotificationType`. If the actual instance is not `EmailNotificationType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EmailNotificationType</returns>
        public EmailNotificationType GetEmailNotificationType()
        {
            return (EmailNotificationType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SmsNotificationType`. If the actual instance is not `SmsNotificationType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SmsNotificationType</returns>
        public SmsNotificationType GetSmsNotificationType()
        {
            return (SmsNotificationType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `WebhookNotificationType`. If the actual instance is not `WebhookNotificationType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of WebhookNotificationType</returns>
        public WebhookNotificationType GetWebhookNotificationType()
        {
            return (WebhookNotificationType)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationType {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, NotificationType.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NotificationType
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NotificationType</returns>
        public static NotificationType FromJson(string jsonString)
        {
            NotificationType newNotificationType = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNotificationType;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AmazonSqsNotificationType).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<AmazonSqsNotificationType>(jsonString, NotificationType.SerializerSettings));
                }
                else
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<AmazonSqsNotificationType>(jsonString, NotificationType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AmazonSqsNotificationType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AmazonSqsNotificationType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AmazonSqsPrincipalAuthNotificationType).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<AmazonSqsPrincipalAuthNotificationType>(jsonString, NotificationType.SerializerSettings));
                }
                else
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<AmazonSqsPrincipalAuthNotificationType>(jsonString, NotificationType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AmazonSqsPrincipalAuthNotificationType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AmazonSqsPrincipalAuthNotificationType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AzureServiceBusNotificationType).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<AzureServiceBusNotificationType>(jsonString, NotificationType.SerializerSettings));
                }
                else
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<AzureServiceBusNotificationType>(jsonString, NotificationType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AzureServiceBusNotificationType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AzureServiceBusNotificationType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EmailNotificationType).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<EmailNotificationType>(jsonString, NotificationType.SerializerSettings));
                }
                else
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<EmailNotificationType>(jsonString, NotificationType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EmailNotificationType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EmailNotificationType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SmsNotificationType).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<SmsNotificationType>(jsonString, NotificationType.SerializerSettings));
                }
                else
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<SmsNotificationType>(jsonString, NotificationType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SmsNotificationType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SmsNotificationType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebhookNotificationType).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<WebhookNotificationType>(jsonString, NotificationType.SerializerSettings));
                }
                else
                {
                    newNotificationType = new NotificationType(JsonConvert.DeserializeObject<WebhookNotificationType>(jsonString, NotificationType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebhookNotificationType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebhookNotificationType: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newNotificationType;
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

    /// <summary>
    /// Custom JSON converter for NotificationType
    /// </summary>
    public class NotificationTypeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NotificationType).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return NotificationType.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return NotificationType.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
