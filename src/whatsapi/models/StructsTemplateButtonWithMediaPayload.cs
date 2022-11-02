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
using OpenAPIDateConverter = WhatsAPI.Client.OpenAPIDateConverter;

namespace WhatsAPI.models
{
    /// <summary>
    /// StructsTemplateButtonWithMediaPayload
    /// </summary>
    [DataContract]
    public partial class StructsTemplateButtonWithMediaPayload :  IEquatable<StructsTemplateButtonWithMediaPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsTemplateButtonWithMediaPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsTemplateButtonWithMediaPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsTemplateButtonWithMediaPayload" /> class.
        /// </summary>
        /// <param name="buttons">buttons (required).</param>
        /// <param name="contentText">contentText.</param>
        /// <param name="footer">footer.</param>
        /// <param name="media">media (required).</param>
        /// <param name="to">to (required).</param>
        public StructsTemplateButtonWithMediaPayload(List<StructsTemplateButton> buttons = default(List<StructsTemplateButton>), string contentText = default(string), string footer = default(string), StructsFileUpload media = default(StructsFileUpload), string to = default(string))
        {
            // to ensure "buttons" is required (not null)
            if (buttons == null)
            {
                throw new InvalidDataException("buttons is a required property for StructsTemplateButtonWithMediaPayload and cannot be null");
            }
            else
            {
                this.Buttons = buttons;
            }

            // to ensure "media" is required (not null)
            if (media == null)
            {
                throw new InvalidDataException("media is a required property for StructsTemplateButtonWithMediaPayload and cannot be null");
            }
            else
            {
                this.Media = media;
            }

            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for StructsTemplateButtonWithMediaPayload and cannot be null");
            }
            else
            {
                this.To = to;
            }

            this.ContentText = contentText;
            this.Footer = footer;
        }

        /// <summary>
        /// Gets or Sets Buttons
        /// </summary>
        [DataMember(Name="buttons", EmitDefaultValue=true)]
        public List<StructsTemplateButton> Buttons { get; set; }

        /// <summary>
        /// Gets or Sets ContentText
        /// </summary>
        [DataMember(Name="content_text", EmitDefaultValue=false)]
        public string ContentText { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public string Footer { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=true)]
        public StructsFileUpload Media { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=true)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructsTemplateButtonWithMediaPayload {\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
            sb.Append("  ContentText: ").Append(ContentText).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as StructsTemplateButtonWithMediaPayload);
        }

        /// <summary>
        /// Returns true if StructsTemplateButtonWithMediaPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsTemplateButtonWithMediaPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsTemplateButtonWithMediaPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buttons == input.Buttons ||
                    this.Buttons != null &&
                    input.Buttons != null &&
                    this.Buttons.SequenceEqual(input.Buttons)
                ) && 
                (
                    this.ContentText == input.ContentText ||
                    (this.ContentText != null &&
                    this.ContentText.Equals(input.ContentText))
                ) && 
                (
                    this.Footer == input.Footer ||
                    (this.Footer != null &&
                    this.Footer.Equals(input.Footer))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.Buttons != null)
                    hashCode = hashCode * 59 + this.Buttons.GetHashCode();
                if (this.ContentText != null)
                    hashCode = hashCode * 59 + this.ContentText.GetHashCode();
                if (this.Footer != null)
                    hashCode = hashCode * 59 + this.Footer.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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
