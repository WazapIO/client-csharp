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
    /// SetGroupPictureRequest
    /// </summary>
    [DataContract]
    public partial class SetGroupPictureRequest :  IEquatable<SetGroupPictureRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetGroupPictureRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetGroupPictureRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetGroupPictureRequest" /> class.
        /// </summary>
        /// <param name="file">Group picture in JPEG (required).</param>
        public SetGroupPictureRequest(System.IO.Stream file = default(System.IO.Stream))
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for SetGroupPictureRequest and cannot be null");
            }
            else
            {
                this.File = file;
            }

        }

        /// <summary>
        /// Group picture in JPEG
        /// </summary>
        /// <value>Group picture in JPEG</value>
        [DataMember(Name="file", EmitDefaultValue=true)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetGroupPictureRequest {\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(input as SetGroupPictureRequest);
        }

        /// <summary>
        /// Returns true if SetGroupPictureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetGroupPictureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetGroupPictureRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
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
