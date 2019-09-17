using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SCIM V2 Photo
    /// </summary>
    [DataContract]
    public partial class Photo :  IEquatable<Photo>
    {
        
        
        
        
        
        /// <summary>
        /// The type of photo.
        /// </summary>
        /// <value>The type of photo.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Photo for "photo"
            /// </summary>
            [EnumMember(Value = "photo")]
            Photo,
            
            /// <summary>
            /// Enum Thumbnail for "thumbnail"
            /// </summary>
            [EnumMember(Value = "thumbnail")]
            Thumbnail
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The type of photo.
        /// </summary>
        /// <value>The type of photo.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Photo" /> class.
        /// </summary>
        /// <param name="Value">The URI of the photo. Photos are limited to 240 KB and JPG, GIF, and PNG formats. Returns a JPG..</param>
        /// <param name="Type">The type of photo..</param>
        public Photo(string Value = null, TypeEnum? Type = null)
        {
            this.Value = Value;
            this.Type = Type;
            
        }
        
        
        
        /// <summary>
        /// The URI of the photo. Photos are limited to 240 KB and JPG, GIF, and PNG formats. Returns a JPG.
        /// </summary>
        /// <value>The URI of the photo. Photos are limited to 240 KB and JPG, GIF, and PNG formats. Returns a JPG.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Photo {\n");
            
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Photo);
        }

        /// <summary>
        /// Returns true if Photo instances are equal
        /// </summary>
        /// <param name="other">Instance of Photo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Photo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }
    }

}
