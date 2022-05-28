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
    /// KeyPerformanceIndicator
    /// </summary>
    [DataContract]
    public partial class KeyPerformanceIndicator :  IEquatable<KeyPerformanceIndicator>
    {
        /// <summary>
        /// The optimization type of the Key Performance Indicator.
        /// </summary>
        /// <value>The optimization type of the Key Performance Indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OptimizationTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Maximization for "Maximization"
            /// </summary>
            [EnumMember(Value = "Maximization")]
            Maximization,
            
            /// <summary>
            /// Enum Minimization for "Minimization"
            /// </summary>
            [EnumMember(Value = "Minimization")]
            Minimization
        }
        /// <summary>
        /// The optimization type of the Key Performance Indicator.
        /// </summary>
        /// <value>The optimization type of the Key Performance Indicator.</value>
        [DataMember(Name="optimizationType", EmitDefaultValue=false)]
        public OptimizationTypeEnum? OptimizationType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPerformanceIndicator" /> class.
        /// </summary>
        public KeyPerformanceIndicator()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Key Performance Indicator.
        /// </summary>
        /// <value>The name of the Key Performance Indicator.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyPerformanceIndicator {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OptimizationType: ").Append(OptimizationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as KeyPerformanceIndicator);
        }

        /// <summary>
        /// Returns true if KeyPerformanceIndicator instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyPerformanceIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyPerformanceIndicator other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.OptimizationType == other.OptimizationType ||
                    this.OptimizationType != null &&
                    this.OptimizationType.Equals(other.OptimizationType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.OptimizationType != null)
                    hash = hash * 59 + this.OptimizationType.GetHashCode();

                return hash;
            }
        }
    }

}
