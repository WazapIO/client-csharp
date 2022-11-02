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
using OpenAPIDateConverter = com.whatsapi.Client.OpenAPIDateConverter;

namespace com.whatsapi.Model
{
    /// <summary>
    /// StructsFileUpload
    /// </summary>
    [DataContract]
    public partial class StructsFileUpload :  IEquatable<StructsFileUpload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsFileUpload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructsFileUpload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructsFileUpload" /> class.
        /// </summary>
        /// <param name="directPath">directPath (required).</param>
        /// <param name="fileEncSha256">fileEncSha256 (required).</param>
        /// <param name="fileLength">fileLength (required).</param>
        /// <param name="fileSha256">fileSha256 (required).</param>
        /// <param name="mediaKey">mediaKey (required).</param>
        /// <param name="mimeType">mimeType (required).</param>
        /// <param name="url">url (required).</param>
        public StructsFileUpload(string directPath = default(string), List<int> fileEncSha256 = default(List<int>), int fileLength = default(int), List<int> fileSha256 = default(List<int>), List<int> mediaKey = default(List<int>), string mimeType = default(string), string url = default(string))
        {
            // to ensure "directPath" is required (not null)
            if (directPath == null)
            {
                throw new InvalidDataException("directPath is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.DirectPath = directPath;
            }

            // to ensure "fileEncSha256" is required (not null)
            if (fileEncSha256 == null)
            {
                throw new InvalidDataException("fileEncSha256 is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.FileEncSha256 = fileEncSha256;
            }

            // to ensure "fileLength" is required (not null)
            if (fileLength == null)
            {
                throw new InvalidDataException("fileLength is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.FileLength = fileLength;
            }

            // to ensure "fileSha256" is required (not null)
            if (fileSha256 == null)
            {
                throw new InvalidDataException("fileSha256 is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.FileSha256 = fileSha256;
            }

            // to ensure "mediaKey" is required (not null)
            if (mediaKey == null)
            {
                throw new InvalidDataException("mediaKey is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.MediaKey = mediaKey;
            }

            // to ensure "mimeType" is required (not null)
            if (mimeType == null)
            {
                throw new InvalidDataException("mimeType is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.MimeType = mimeType;
            }

            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for StructsFileUpload and cannot be null");
            }
            else
            {
                this.Url = url;
            }

        }

        /// <summary>
        /// Gets or Sets DirectPath
        /// </summary>
        [DataMember(Name="direct_path", EmitDefaultValue=true)]
        public string DirectPath { get; set; }

        /// <summary>
        /// Gets or Sets FileEncSha256
        /// </summary>
        [DataMember(Name="file_enc_sha256", EmitDefaultValue=true)]
        public List<int> FileEncSha256 { get; set; }

        /// <summary>
        /// Gets or Sets FileLength
        /// </summary>
        [DataMember(Name="file_length", EmitDefaultValue=true)]
        public int FileLength { get; set; }

        /// <summary>
        /// Gets or Sets FileSha256
        /// </summary>
        [DataMember(Name="file_sha256", EmitDefaultValue=true)]
        public List<int> FileSha256 { get; set; }

        /// <summary>
        /// Gets or Sets MediaKey
        /// </summary>
        [DataMember(Name="media_key", EmitDefaultValue=true)]
        public List<int> MediaKey { get; set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mime_type", EmitDefaultValue=true)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructsFileUpload {\n");
            sb.Append("  DirectPath: ").Append(DirectPath).Append("\n");
            sb.Append("  FileEncSha256: ").Append(FileEncSha256).Append("\n");
            sb.Append("  FileLength: ").Append(FileLength).Append("\n");
            sb.Append("  FileSha256: ").Append(FileSha256).Append("\n");
            sb.Append("  MediaKey: ").Append(MediaKey).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as StructsFileUpload);
        }

        /// <summary>
        /// Returns true if StructsFileUpload instances are equal
        /// </summary>
        /// <param name="input">Instance of StructsFileUpload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructsFileUpload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectPath == input.DirectPath ||
                    (this.DirectPath != null &&
                    this.DirectPath.Equals(input.DirectPath))
                ) && 
                (
                    this.FileEncSha256 == input.FileEncSha256 ||
                    this.FileEncSha256 != null &&
                    input.FileEncSha256 != null &&
                    this.FileEncSha256.SequenceEqual(input.FileEncSha256)
                ) && 
                (
                    this.FileLength == input.FileLength ||
                    (this.FileLength != null &&
                    this.FileLength.Equals(input.FileLength))
                ) && 
                (
                    this.FileSha256 == input.FileSha256 ||
                    this.FileSha256 != null &&
                    input.FileSha256 != null &&
                    this.FileSha256.SequenceEqual(input.FileSha256)
                ) && 
                (
                    this.MediaKey == input.MediaKey ||
                    this.MediaKey != null &&
                    input.MediaKey != null &&
                    this.MediaKey.SequenceEqual(input.MediaKey)
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.DirectPath != null)
                    hashCode = hashCode * 59 + this.DirectPath.GetHashCode();
                if (this.FileEncSha256 != null)
                    hashCode = hashCode * 59 + this.FileEncSha256.GetHashCode();
                if (this.FileLength != null)
                    hashCode = hashCode * 59 + this.FileLength.GetHashCode();
                if (this.FileSha256 != null)
                    hashCode = hashCode * 59 + this.FileSha256.GetHashCode();
                if (this.MediaKey != null)
                    hashCode = hashCode * 59 + this.MediaKey.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
