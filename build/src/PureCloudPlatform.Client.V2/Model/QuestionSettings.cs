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
    /// QuestionSettings
    /// </summary>
    [DataContract]
    public partial class QuestionSettings :  IEquatable<QuestionSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionSettings" /> class.
        /// </summary>
        /// <param name="QuestionIndex">This field represents the location of the Question in the form. Note: Indexes are zero-based.</param>
        /// <param name="Settings">Settings.</param>
        public QuestionSettings(int? QuestionIndex = null, AiScoringSetting Settings = null)
        {
            this.QuestionIndex = QuestionIndex;
            this.Settings = Settings;
            
        }
        


        /// <summary>
        /// This field represents the location of the Question in the form. Note: Indexes are zero-based
        /// </summary>
        /// <value>This field represents the location of the Question in the form. Note: Indexes are zero-based</value>
        [DataMember(Name="questionIndex", EmitDefaultValue=false)]
        public int? QuestionIndex { get; set; }



        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public AiScoringSetting Settings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionSettings {\n");

            sb.Append("  QuestionIndex: ").Append(QuestionIndex).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(obj as QuestionSettings);
        }

        /// <summary>
        /// Returns true if QuestionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of QuestionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuestionIndex == other.QuestionIndex ||
                    this.QuestionIndex != null &&
                    this.QuestionIndex.Equals(other.QuestionIndex)
                ) &&
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
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
                if (this.QuestionIndex != null)
                    hash = hash * 59 + this.QuestionIndex.GetHashCode();

                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();

                return hash;
            }
        }
    }

}
