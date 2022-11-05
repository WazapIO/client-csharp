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
    /// ListSection
    /// </summary>
    [DataContract]
    public partial class ListSection :  IEquatable<ListSection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSection" /> class.
        /// </summary>
        /// <param name="rows">rows (required).</param>
        /// <param name="title">title (required).</param>
        public ListSection(List<ListItem> rows = default(List<ListItem>), string title = default(string))
        {
            // to ensure "rows" is required (not null)
            if (rows == null)
            {
                throw new InvalidDataException("rows is a required property for ListSection and cannot be null");
            }
            else
            {
                this.Rows = rows;
            }

            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ListSection and cannot be null");
            }
            else
            {
                this.Title = title;
            }

        }

        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [DataMember(Name="rows", EmitDefaultValue=true)]
        public List<ListItem> Rows { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSection {\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ListSection);
        }

        /// <summary>
        /// Returns true if ListSection instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
