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
    /// SCIM V2 User
    /// </summary>
    [DataContract]
    public partial class ScimV2User :  IEquatable<ScimV2User>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2User" /> class.
        /// </summary>
        /// <param name="Schemas">The list of supported schemas..</param>
        /// <param name="Active">Indicates whether the user&#39;s administrative status is active..</param>
        /// <param name="UserName">The user&#39;s PureCloud email address. Must be unique..</param>
        /// <param name="DisplayName">The display name of the user..</param>
        /// <param name="Password">The new password for the PureCloud user. Does not return an existing password..</param>
        /// <param name="Title">The user&#39;s title..</param>
        /// <param name="PhoneNumbers">The list of the user&#39;s phone numbers..</param>
        /// <param name="Emails">The list of the user&#39;s email addresses..</param>
        /// <param name="Photos">The list of the user&#39;s photos..</param>
        /// <param name="ExternalId">The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;..</param>
        /// <param name="Groups">The list of groups that the user is a member of..</param>
        /// <param name="Roles">The list of roles assigned to the user..</param>
        /// <param name="Urnietfparamsscimschemasextensionenterprise20User">Urnietfparamsscimschemasextensionenterprise20User.</param>
        /// <param name="Meta">Resource SCIM meta.</param>
        public ScimV2User(List<string> Schemas = null, bool? Active = null, string UserName = null, string DisplayName = null, string Password = null, string Title = null, List<ScimPhoneNumber> PhoneNumbers = null, List<ScimEmail> Emails = null, List<Photo> Photos = null, string ExternalId = null, List<ScimV2GroupReference> Groups = null, List<string> Roles = null, ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User = null, ScimMetadata Meta = null)
        {
            this.Schemas = Schemas;
            this.Active = Active;
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.Password = Password;
            this.Title = Title;
            this.PhoneNumbers = PhoneNumbers;
            this.Emails = Emails;
            this.Photos = Photos;
            this.ExternalId = ExternalId;
            this.Groups = Groups;
            this.Roles = Roles;
            this.Urnietfparamsscimschemasextensionenterprise20User = Urnietfparamsscimschemasextensionenterprise20User;
            this.Meta = Meta;
            
        }
        
        
        
        /// <summary>
        /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;Mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;Returned\&quot; is set to \&quot;always\&quot;.
        /// </summary>
        /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;Mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;Returned\&quot; is set to \&quot;always\&quot;.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The list of supported schemas.
        /// </summary>
        /// <value>The list of supported schemas.</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether the user&#39;s administrative status is active.
        /// </summary>
        /// <value>Indicates whether the user&#39;s administrative status is active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        
        
        
        /// <summary>
        /// The user&#39;s PureCloud email address. Must be unique.
        /// </summary>
        /// <value>The user&#39;s PureCloud email address. Must be unique.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        
        
        
        /// <summary>
        /// The display name of the user.
        /// </summary>
        /// <value>The display name of the user.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        /// <summary>
        /// The new password for the PureCloud user. Does not return an existing password.
        /// </summary>
        /// <value>The new password for the PureCloud user. Does not return an existing password.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        
        
        
        /// <summary>
        /// The user&#39;s title.
        /// </summary>
        /// <value>The user&#39;s title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// The list of the user&#39;s phone numbers.
        /// </summary>
        /// <value>The list of the user&#39;s phone numbers.</value>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<ScimPhoneNumber> PhoneNumbers { get; set; }
        
        
        
        /// <summary>
        /// The list of the user&#39;s email addresses.
        /// </summary>
        /// <value>The list of the user&#39;s email addresses.</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<ScimEmail> Emails { get; set; }
        
        
        
        /// <summary>
        /// The list of the user&#39;s photos.
        /// </summary>
        /// <value>The list of the user&#39;s photos.</value>
        [DataMember(Name="photos", EmitDefaultValue=false)]
        public List<Photo> Photos { get; set; }
        
        
        
        /// <summary>
        /// The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.
        /// </summary>
        /// <value>The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        
        
        
        /// <summary>
        /// The list of groups that the user is a member of.
        /// </summary>
        /// <value>The list of groups that the user is a member of.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<ScimV2GroupReference> Groups { get; set; }
        
        
        
        /// <summary>
        /// The list of roles assigned to the user.
        /// </summary>
        /// <value>The list of roles assigned to the user.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Urnietfparamsscimschemasextensionenterprise20User
        /// </summary>
        [DataMember(Name="urn:ietf:params:scim:schemas:extension:enterprise:2.0:User", EmitDefaultValue=false)]
        public ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User { get; set; }
        
        
        
        /// <summary>
        /// Resource SCIM meta
        /// </summary>
        /// <value>Resource SCIM meta</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public ScimMetadata Meta { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2User {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Urnietfparamsscimschemasextensionenterprise20User: ").Append(Urnietfparamsscimschemasextensionenterprise20User).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(obj as ScimV2User);
        }

        /// <summary>
        /// Returns true if ScimV2User instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2User other)
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
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.PhoneNumbers == other.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(other.PhoneNumbers)
                ) &&
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) &&
                (
                    this.Photos == other.Photos ||
                    this.Photos != null &&
                    this.Photos.SequenceEqual(other.Photos)
                ) &&
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) &&
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) &&
                (
                    this.Urnietfparamsscimschemasextensionenterprise20User == other.Urnietfparamsscimschemasextensionenterprise20User ||
                    this.Urnietfparamsscimschemasextensionenterprise20User != null &&
                    this.Urnietfparamsscimschemasextensionenterprise20User.Equals(other.Urnietfparamsscimschemasextensionenterprise20User)
                ) &&
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.PhoneNumbers != null)
                    hash = hash * 59 + this.PhoneNumbers.GetHashCode();
                
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                
                if (this.Photos != null)
                    hash = hash * 59 + this.Photos.GetHashCode();
                
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                
                if (this.Urnietfparamsscimschemasextensionenterprise20User != null)
                    hash = hash * 59 + this.Urnietfparamsscimschemasextensionenterprise20User.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }
    }

}
