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
using OpenAPIDateConverter = whatsapi.Client.OpenAPIDateConverter;

namespace whatsapi.Model
{
    /// <summary>
    /// StructsButtonMessageWithMediaPayload
    /// </summary>
    [DataContract]
    public partial class StructsButtonMessageWithMediaPayload :  IEquatable<StructsButtonMessageWithMediaPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsButtonMessageWithMediaPayload" /> class.
        /// </summary>
        /// <param name="buttons">buttons.</param>
        /// <param name="footerText">footerText.</param>
        /// <param name="mediaData">mediaData.</param>
        /// <param name="text">text.</param>
        /// <param name="to">to.</param>
        public StructsButtonMessageWithMediaPayload(List<StructsReplyButton> buttons = default(List<StructsReplyButton>), string footerText = default(string), StructsFileUpload mediaData = default(StructsFileUpload), string text = default(string), string to = default(string))
        {
            this.Buttons = buttons;
            this.FooterText = footerText;
            this.MediaData = mediaData;
            this.Text = text;
            this.To = to;
        }

        /// <summary>
        /// Gets or Sets Buttons
        /// </summary>
        [DataMember(Name="buttons", EmitDefaultValue=false)]
        public List<StructsReplyButton> Buttons { get; set; }

        /// <summary>
        /// Gets or Sets FooterText
        /// </summary>
        [DataMember(Name="footer_text", EmitDefaultValue=false)]
        public string FooterText { get; set; }

        /// <summary>
        /// Gets or Sets MediaData
        /// </summary>
        [DataMember(Name="media_data", EmitDefaultValue=false)]
        public StructsFileUpload MediaData { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructsButtonMessageWithMediaPayload {\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
            sb.Append("  FooterText: ").Append(FooterText).Append("\n");
            sb.Append("  MediaData: ").Append(MediaData).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as StructsButtonMessageWithMediaPayload);
        }

        /// <summary>
        /// Returns true if StructsButtonMessageWithMediaPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsButtonMessageWithMediaPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsButtonMessageWithMediaPayload input)
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
                    this.FooterText == input.FooterText ||
                    (this.FooterText != null &&
                    this.FooterText.Equals(input.FooterText))
                ) && 
                (
                    this.MediaData == input.MediaData ||
                    (this.MediaData != null &&
                    this.MediaData.Equals(input.MediaData))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.FooterText != null)
                    hashCode = hashCode * 59 + this.FooterText.GetHashCode();
                if (this.MediaData != null)
                    hashCode = hashCode * 59 + this.MediaData.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
