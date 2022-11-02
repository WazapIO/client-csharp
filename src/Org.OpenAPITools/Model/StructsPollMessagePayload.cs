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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// StructsPollMessagePayload
    /// </summary>
    [DataContract]
    public partial class StructsPollMessagePayload :  IEquatable<StructsPollMessagePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsPollMessagePayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsPollMessagePayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsPollMessagePayload" /> class.
        /// </summary>
        /// <param name="options">options (required).</param>
        /// <param name="selectableOptionsCount">selectableOptionsCount (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="to">to (required).</param>
        public StructsPollMessagePayload(List<string> options = default(List<string>), int selectableOptionsCount = default(int), string title = default(string), string to = default(string))
        {
            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new InvalidDataException("options is a required property for StructsPollMessagePayload and cannot be null");
            }
            else
            {
                this.Options = options;
            }

            // to ensure "selectableOptionsCount" is required (not null)
            if (selectableOptionsCount == null)
            {
                throw new InvalidDataException("selectableOptionsCount is a required property for StructsPollMessagePayload and cannot be null");
            }
            else
            {
                this.SelectableOptionsCount = selectableOptionsCount;
            }

            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for StructsPollMessagePayload and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for StructsPollMessagePayload and cannot be null");
            }
            else
            {
                this.To = to;
            }

        }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=true)]
        public List<string> Options { get; set; }

        /// <summary>
        /// Gets or Sets SelectableOptionsCount
        /// </summary>
        [DataMember(Name="selectable_options_count", EmitDefaultValue=true)]
        public int SelectableOptionsCount { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

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
            sb.Append("class StructsPollMessagePayload {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  SelectableOptionsCount: ").Append(SelectableOptionsCount).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as StructsPollMessagePayload);
        }

        /// <summary>
        /// Returns true if StructsPollMessagePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsPollMessagePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsPollMessagePayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.SelectableOptionsCount == input.SelectableOptionsCount ||
                    (this.SelectableOptionsCount != null &&
                    this.SelectableOptionsCount.Equals(input.SelectableOptionsCount))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.SelectableOptionsCount != null)
                    hashCode = hashCode * 59 + this.SelectableOptionsCount.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
