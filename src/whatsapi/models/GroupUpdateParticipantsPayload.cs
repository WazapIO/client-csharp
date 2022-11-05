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
    /// GroupUpdateParticipantsPayload
    /// </summary>
    [DataContract]
    public partial class GroupUpdateParticipantsPayload :  IEquatable<GroupUpdateParticipantsPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateParticipantsPayload" /> class.
        /// </summary>
        /// <param name="participants">participants.</param>
        public GroupUpdateParticipantsPayload(List<string> participants = default(List<string>))
        {
            this.Participants = participants;
        }

        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<string> Participants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupUpdateParticipantsPayload {\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
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
            return this.Equals(input as GroupUpdateParticipantsPayload);
        }

        /// <summary>
        /// Returns true if GroupUpdateParticipantsPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupUpdateParticipantsPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupUpdateParticipantsPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Participants == input.Participants ||
                    this.Participants != null &&
                    input.Participants != null &&
                    this.Participants.SequenceEqual(input.Participants)
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
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
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
