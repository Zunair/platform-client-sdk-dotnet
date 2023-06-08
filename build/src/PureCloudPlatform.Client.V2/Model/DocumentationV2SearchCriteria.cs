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
    /// DocumentationV2SearchCriteria
    /// </summary>
    [DataContract]
    public partial class DocumentationV2SearchCriteria :  IEquatable<DocumentationV2SearchCriteria>
    {
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or,
            
            /// <summary>
            /// Enum Not for "NOT"
            /// </summary>
            [EnumMember(Value = "NOT")]
            Not
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Simple for "SIMPLE"
            /// </summary>
            [EnumMember(Value = "SIMPLE")]
            Simple,
            
            /// <summary>
            /// Enum Exact for "EXACT"
            /// </summary>
            [EnumMember(Value = "EXACT")]
            Exact
        }
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationV2SearchCriteria" /> class.
        /// </summary>
        /// <param name="EndValue">The end value of the range. This field is used for range search types..</param>
        /// <param name="Values">A list of values for the search to match against.</param>
        /// <param name="StartValue">The start value of the range. This field is used for range search types..</param>
        /// <param name="Value">A value for the search to match against.</param>
        /// <param name="Operator">How to apply this search criteria against other criteria.</param>
        /// <param name="Group">Groups multiple conditions.</param>
        /// <param name="DateFormat">Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd'T'HH:mm:ss.SSSX..</param>
        /// <param name="Type">Type.</param>
        /// <param name="Fields">Field names to search against.</param>
        public DocumentationV2SearchCriteria(string EndValue = null, List<string> Values = null, string StartValue = null, string Value = null, OperatorEnum? Operator = null, List<DocumentationV2SearchCriteria> Group = null, string DateFormat = null, TypeEnum? Type = null, List<string> Fields = null)
        {
            this.EndValue = EndValue;
            this.Values = Values;
            this.StartValue = StartValue;
            this.Value = Value;
            this.Operator = Operator;
            this.Group = Group;
            this.DateFormat = DateFormat;
            this.Type = Type;
            this.Fields = Fields;
            
        }
        


        /// <summary>
        /// The end value of the range. This field is used for range search types.
        /// </summary>
        /// <value>The end value of the range. This field is used for range search types.</value>
        [DataMember(Name="endValue", EmitDefaultValue=false)]
        public string EndValue { get; set; }



        /// <summary>
        /// A list of values for the search to match against
        /// </summary>
        /// <value>A list of values for the search to match against</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }



        /// <summary>
        /// The start value of the range. This field is used for range search types.
        /// </summary>
        /// <value>The start value of the range. This field is used for range search types.</value>
        [DataMember(Name="startValue", EmitDefaultValue=false)]
        public string StartValue { get; set; }



        /// <summary>
        /// A value for the search to match against
        /// </summary>
        /// <value>A value for the search to match against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }





        /// <summary>
        /// Groups multiple conditions
        /// </summary>
        /// <value>Groups multiple conditions</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public List<DocumentationV2SearchCriteria> Group { get; set; }



        /// <summary>
        /// Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd'T'HH:mm:ss.SSSX.
        /// </summary>
        /// <value>Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd'T'HH:mm:ss.SSSX.</value>
        [DataMember(Name="dateFormat", EmitDefaultValue=false)]
        public string DateFormat { get; set; }





        /// <summary>
        /// Field names to search against
        /// </summary>
        /// <value>Field names to search against</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentationV2SearchCriteria {\n");

            sb.Append("  EndValue: ").Append(EndValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  StartValue: ").Append(StartValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(obj as DocumentationV2SearchCriteria);
        }

        /// <summary>
        /// Returns true if DocumentationV2SearchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentationV2SearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentationV2SearchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndValue == other.EndValue ||
                    this.EndValue != null &&
                    this.EndValue.Equals(other.EndValue)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.StartValue == other.StartValue ||
                    this.StartValue != null &&
                    this.StartValue.Equals(other.StartValue)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) &&
                (
                    this.DateFormat == other.DateFormat ||
                    this.DateFormat != null &&
                    this.DateFormat.Equals(other.DateFormat)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
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
                if (this.EndValue != null)
                    hash = hash * 59 + this.EndValue.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.StartValue != null)
                    hash = hash * 59 + this.StartValue.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.DateFormat != null)
                    hash = hash * 59 + this.DateFormat.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();

                return hash;
            }
        }
    }

}
