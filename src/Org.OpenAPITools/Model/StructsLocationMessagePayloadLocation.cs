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
    /// StructsLocationMessagePayloadLocation
    /// </summary>
    [DataContract]
    public partial class StructsLocationMessagePayloadLocation :  IEquatable<StructsLocationMessagePayloadLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsLocationMessagePayloadLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsLocationMessagePayloadLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsLocationMessagePayloadLocation" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="latitude">latitude (required).</param>
        /// <param name="longitude">longitude (required).</param>
        /// <param name="name">name (required).</param>
        public StructsLocationMessagePayloadLocation(string address = default(string), decimal latitude = default(decimal), decimal longitude = default(decimal), string name = default(string))
        {
            // to ensure "latitude" is required (not null)
            if (latitude == null)
            {
                throw new InvalidDataException("latitude is a required property for StructsLocationMessagePayloadLocation and cannot be null");
            }
            else
            {
                this.Latitude = latitude;
            }

            // to ensure "longitude" is required (not null)
            if (longitude == null)
            {
                throw new InvalidDataException("longitude is a required property for StructsLocationMessagePayloadLocation and cannot be null");
            }
            else
            {
                this.Longitude = longitude;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for StructsLocationMessagePayloadLocation and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=true)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=true)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructsLocationMessagePayloadLocation {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as StructsLocationMessagePayloadLocation);
        }

        /// <summary>
        /// Returns true if StructsLocationMessagePayloadLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsLocationMessagePayloadLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsLocationMessagePayloadLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
