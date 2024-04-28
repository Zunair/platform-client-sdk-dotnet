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
    /// KnowledgeDocumentView
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentView :  IEquatable<KnowledgeDocumentView>
    {
        /// <summary>
        /// The type of the query that surfaced the document.
        /// </summary>
        /// <value>The type of the query that surfaced the document.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QueryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Autosearch for "AutoSearch"
            /// </summary>
            [EnumMember(Value = "AutoSearch")]
            Autosearch,
            
            /// <summary>
            /// Enum Category for "Category"
            /// </summary>
            [EnumMember(Value = "Category")]
            Category,
            
            /// <summary>
            /// Enum Manualsearch for "ManualSearch"
            /// </summary>
            [EnumMember(Value = "ManualSearch")]
            Manualsearch,
            
            /// <summary>
            /// Enum Recommendation for "Recommendation"
            /// </summary>
            [EnumMember(Value = "Recommendation")]
            Recommendation,
            
            /// <summary>
            /// Enum Suggestion for "Suggestion"
            /// </summary>
            [EnumMember(Value = "Suggestion")]
            Suggestion
        }
        /// <summary>
        /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.
        /// </summary>
        /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SurfacingMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Snippet for "Snippet"
            /// </summary>
            [EnumMember(Value = "Snippet")]
            Snippet,
            
            /// <summary>
            /// Enum Highlight for "Highlight"
            /// </summary>
            [EnumMember(Value = "Highlight")]
            Highlight
        }
        /// <summary>
        /// The type of the query that surfaced the document.
        /// </summary>
        /// <value>The type of the query that surfaced the document.</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }
        /// <summary>
        /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.
        /// </summary>
        /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.</value>
        [DataMember(Name="surfacingMethod", EmitDefaultValue=false)]
        public SurfacingMethodEnum? SurfacingMethod { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentView" /> class.
        /// </summary>
        /// <param name="DocumentVariationId">The variation of the viewed document. (required).</param>
        /// <param name="DocumentVersionId">The version of the viewed document. (required).</param>
        /// <param name="SearchId">The search that surfaced the viewed document..</param>
        /// <param name="QueryType">The type of the query that surfaced the document..</param>
        /// <param name="SurfacingMethod">The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown..</param>
        /// <param name="Application">The client application from which the document was viewed. (required).</param>
        /// <param name="SessionId">The unique identifier of the knowledge session in which the document was viewed..</param>
        /// <param name="ConversationContext">Conversation context information if the document was viewed in the context of a conversation..</param>
        public KnowledgeDocumentView(string DocumentVariationId = null, string DocumentVersionId = null, string SearchId = null, QueryTypeEnum? QueryType = null, SurfacingMethodEnum? SurfacingMethod = null, KnowledgeSearchClientApplication Application = null, string SessionId = null, KnowledgeConversationContext ConversationContext = null)
        {
            this.DocumentVariationId = DocumentVariationId;
            this.DocumentVersionId = DocumentVersionId;
            this.SearchId = SearchId;
            this.QueryType = QueryType;
            this.SurfacingMethod = SurfacingMethod;
            this.Application = Application;
            this.SessionId = SessionId;
            this.ConversationContext = ConversationContext;
            
        }
        


        /// <summary>
        /// The variation of the viewed document.
        /// </summary>
        /// <value>The variation of the viewed document.</value>
        [DataMember(Name="documentVariationId", EmitDefaultValue=false)]
        public string DocumentVariationId { get; set; }



        /// <summary>
        /// The version of the viewed document.
        /// </summary>
        /// <value>The version of the viewed document.</value>
        [DataMember(Name="documentVersionId", EmitDefaultValue=false)]
        public string DocumentVersionId { get; set; }



        /// <summary>
        /// The search that surfaced the viewed document.
        /// </summary>
        /// <value>The search that surfaced the viewed document.</value>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; set; }







        /// <summary>
        /// The client application from which the document was viewed.
        /// </summary>
        /// <value>The client application from which the document was viewed.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public KnowledgeSearchClientApplication Application { get; set; }



        /// <summary>
        /// The unique identifier of the knowledge session in which the document was viewed.
        /// </summary>
        /// <value>The unique identifier of the knowledge session in which the document was viewed.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Conversation context information if the document was viewed in the context of a conversation.
        /// </summary>
        /// <value>Conversation context information if the document was viewed in the context of a conversation.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeConversationContext ConversationContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentView {\n");

            sb.Append("  DocumentVariationId: ").Append(DocumentVariationId).Append("\n");
            sb.Append("  DocumentVersionId: ").Append(DocumentVersionId).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  SurfacingMethod: ").Append(SurfacingMethod).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentView);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentView instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentView other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DocumentVariationId == other.DocumentVariationId ||
                    this.DocumentVariationId != null &&
                    this.DocumentVariationId.Equals(other.DocumentVariationId)
                ) &&
                (
                    this.DocumentVersionId == other.DocumentVersionId ||
                    this.DocumentVersionId != null &&
                    this.DocumentVersionId.Equals(other.DocumentVersionId)
                ) &&
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.SurfacingMethod == other.SurfacingMethod ||
                    this.SurfacingMethod != null &&
                    this.SurfacingMethod.Equals(other.SurfacingMethod)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.ConversationContext == other.ConversationContext ||
                    this.ConversationContext != null &&
                    this.ConversationContext.Equals(other.ConversationContext)
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
                if (this.DocumentVariationId != null)
                    hash = hash * 59 + this.DocumentVariationId.GetHashCode();

                if (this.DocumentVersionId != null)
                    hash = hash * 59 + this.DocumentVersionId.GetHashCode();

                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.SurfacingMethod != null)
                    hash = hash * 59 + this.SurfacingMethod.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                return hash;
            }
        }
    }

}
