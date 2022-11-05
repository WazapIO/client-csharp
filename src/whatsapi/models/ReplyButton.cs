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
    /// ReplyButton
    /// </summary>
    [DataContract]
    public partial class ReplyButton :  IEquatable<ReplyButton>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyButton" /> class.
        /// </summary>
        /// <param name="buttonId">buttonId.</param>
        /// <param name="buttonText">buttonText.</param>
        public ReplyButton(string buttonId = default(string), string buttonText = default(string))
        {
            this.ButtonId = buttonId;
            this.ButtonText = buttonText;
        }

        /// <summary>
        /// Gets or Sets ButtonId
        /// </summary>
        [DataMember(Name="button_id", EmitDefaultValue=false)]
        public string ButtonId { get; set; }

        /// <summary>
        /// Gets or Sets ButtonText
        /// </summary>
        [DataMember(Name="button_text", EmitDefaultValue=false)]
        public string ButtonText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplyButton {\n");
            sb.Append("  ButtonId: ").Append(ButtonId).Append("\n");
            sb.Append("  ButtonText: ").Append(ButtonText).Append("\n");
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
            return this.Equals(input as ReplyButton);
        }

        /// <summary>
        /// Returns true if ReplyButton instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplyButton to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplyButton input)
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
                    this.ButtonText == input.ButtonText ||
                    (this.ButtonText != null &&
                    this.ButtonText.Equals(input.ButtonText))
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
                if (this.ButtonText != null)
                    hashCode = hashCode * 59 + this.ButtonText.GetHashCode();
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
