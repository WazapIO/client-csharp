/*
 * WhatsAPI Go
 *
 * The V2 of WhatsAPI Go
 *
 * The version of the OpenAPI document: 2.0
 * Contact: manjit@sponsorbook.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.whatsapi.Client.OpenAPIDateConverter;

namespace com.whatsapi.Model
{
    /// <summary>
    /// StructsTemplateButton
    /// </summary>
    [DataContract]
    public partial class StructsTemplateButton :  IEquatable<StructsTemplateButton>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsTemplateButton" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsTemplateButton() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsTemplateButton" /> class.
        /// </summary>
        /// <param name="buttonId">Make sure this is unique.</param>
        /// <param name="payload">payload.</param>
        /// <param name="title">title (required).</param>
        /// <param name="type">Valid types are replyButton, urlButton &amp; callButton (required).</param>
        public StructsTemplateButton(string buttonId = default(string), string payload = default(string), string title = default(string), string type = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for StructsTemplateButton and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for StructsTemplateButton and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.ButtonId = buttonId;
            this.Payload = payload;
        }

        /// <summary>
        /// Make sure this is unique
        /// </summary>
        /// <value>Make sure this is unique</value>
        [DataMember(Name="button_id", EmitDefaultValue=false)]
        public string ButtonId { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Valid types are replyButton, urlButton &amp; callButton
        /// </summary>
        /// <value>Valid types are replyButton, urlButton &amp; callButton</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructsTemplateButton {\n");
            sb.Append("  ButtonId: ").Append(ButtonId).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StructsTemplateButton);
        }

        /// <summary>
        /// Returns true if StructsTemplateButton instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsTemplateButton to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsTemplateButton input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ButtonId == input.ButtonId ||
                    (this.ButtonId != null &&
                    this.ButtonId.Equals(input.ButtonId))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ButtonId != null)
                    hashCode = hashCode * 59 + this.ButtonId.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
