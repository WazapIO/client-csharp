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
    /// InstancesInstanceKeySendDocumentPostRequest
    /// </summary>
    [DataContract]
    public partial class InstancesInstanceKeySendDocumentPostRequest :  IEquatable<InstancesInstanceKeySendDocumentPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesInstanceKeySendDocumentPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstancesInstanceKeySendDocumentPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesInstanceKeySendDocumentPostRequest" /> class.
        /// </summary>
        /// <param name="file">Document file (required).</param>
        public InstancesInstanceKeySendDocumentPostRequest(System.IO.Stream file = default(System.IO.Stream))
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for InstancesInstanceKeySendDocumentPostRequest and cannot be null");
            }
            else
            {
                this.File = file;
            }

        }

        /// <summary>
        /// Document file
        /// </summary>
        /// <value>Document file</value>
        [DataMember(Name="file", EmitDefaultValue=true)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesInstanceKeySendDocumentPostRequest {\n");
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
            return this.Equals(input as InstancesInstanceKeySendDocumentPostRequest);
        }

        /// <summary>
        /// Returns true if InstancesInstanceKeySendDocumentPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InstancesInstanceKeySendDocumentPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesInstanceKeySendDocumentPostRequest input)
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
