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
    /// StructsListItem
    /// </summary>
    [DataContract]
    public partial class StructsListItem :  IEquatable<StructsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsListItem" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="rowId">rowId.</param>
        /// <param name="title">title (required).</param>
        public StructsListItem(string description = default(string), string rowId = default(string), string title = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for StructsListItem and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            this.Description = description;
            this.RowId = rowId;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RowId
        /// </summary>
        [DataMember(Name="row_id", EmitDefaultValue=false)]
        public string RowId { get; set; }

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
            sb.Append("class StructsListItem {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RowId: ").Append(RowId).Append("\n");
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
            return this.Equals(input as StructsListItem);
        }

        /// <summary>
        /// Returns true if StructsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RowId == input.RowId ||
                    (this.RowId != null &&
                    this.RowId.Equals(input.RowId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RowId != null)
                    hashCode = hashCode * 59 + this.RowId.GetHashCode();
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
