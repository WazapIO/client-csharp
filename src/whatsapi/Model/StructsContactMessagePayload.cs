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
    /// StructsContactMessagePayload
    /// </summary>
    [DataContract]
    public partial class StructsContactMessagePayload :  IEquatable<StructsContactMessagePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsContactMessagePayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsContactMessagePayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsContactMessagePayload" /> class.
        /// </summary>
        /// <param name="to">to (required).</param>
        /// <param name="vcard">vcard (required).</param>
        public StructsContactMessagePayload(string to = default(string), StructsContactMessagePayloadVcard vcard = default(StructsContactMessagePayloadVcard))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for StructsContactMessagePayload and cannot be null");
            }
            else
            {
                this.To = to;
            }

            // to ensure "vcard" is required (not null)
            if (vcard == null)
            {
                throw new InvalidDataException("vcard is a required property for StructsContactMessagePayload and cannot be null");
            }
            else
            {
                this.Vcard = vcard;
            }

        }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=true)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Vcard
        /// </summary>
        [DataMember(Name="vcard", EmitDefaultValue=true)]
        public StructsContactMessagePayloadVcard Vcard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructsContactMessagePayload {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Vcard: ").Append(Vcard).Append("\n");
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
            return this.Equals(input as StructsContactMessagePayload);
        }

        /// <summary>
        /// Returns true if StructsContactMessagePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsContactMessagePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsContactMessagePayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Vcard == input.Vcard ||
                    (this.Vcard != null &&
                    this.Vcard.Equals(input.Vcard))
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Vcard != null)
                    hashCode = hashCode * 59 + this.Vcard.GetHashCode();
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