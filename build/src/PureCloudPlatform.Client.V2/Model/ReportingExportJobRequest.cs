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
    /// ReportingExportJobRequest
    /// </summary>
    [DataContract]
    public partial class ReportingExportJobRequest :  IEquatable<ReportingExportJobRequest>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The requested format of the exported data
        /// </summary>
        /// <value>The requested format of the exported data</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportFormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Csv for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            Csv
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of view export job to be created
        /// </summary>
        /// <value>The type of view export job to be created</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ViewTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum QueuePerformanceSummaryView for "QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            QueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum QueuePerformanceDetailView for "QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_DETAIL_VIEW")]
            QueuePerformanceDetailView,
            
            /// <summary>
            /// Enum InteractionSearchView for "INTERACTION_SEARCH_VIEW"
            /// </summary>
            [EnumMember(Value = "INTERACTION_SEARCH_VIEW")]
            InteractionSearchView,
            
            /// <summary>
            /// Enum AgentPerformanceSummaryView for "AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_SUMMARY_VIEW")]
            AgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentPerformanceDetailView for "AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_DETAIL_VIEW")]
            AgentPerformanceDetailView,
            
            /// <summary>
            /// Enum AgentStatusSummaryView for "AGENT_STATUS_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_SUMMARY_VIEW")]
            AgentStatusSummaryView,
            
            /// <summary>
            /// Enum AgentStatusDetailView for "AGENT_STATUS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_DETAIL_VIEW")]
            AgentStatusDetailView,
            
            /// <summary>
            /// Enum AgentEvaluationSummaryView for "AGENT_EVALUATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_SUMMARY_VIEW")]
            AgentEvaluationSummaryView,
            
            /// <summary>
            /// Enum AgentEvaluationDetailView for "AGENT_EVALUATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_DETAIL_VIEW")]
            AgentEvaluationDetailView,
            
            /// <summary>
            /// Enum AgentQueueDetailView for "AGENT_QUEUE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_DETAIL_VIEW")]
            AgentQueueDetailView,
            
            /// <summary>
            /// Enum AgentInteractionDetailView for "AGENT_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_INTERACTION_DETAIL_VIEW")]
            AgentInteractionDetailView,
            
            /// <summary>
            /// Enum AbandonInsightsView for "ABANDON_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ABANDON_INSIGHTS_VIEW")]
            AbandonInsightsView,
            
            /// <summary>
            /// Enum SkillsPerformanceView for "SKILLS_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "SKILLS_PERFORMANCE_VIEW")]
            SkillsPerformanceView
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The requested format of the exported data
        /// </summary>
        /// <value>The requested format of the exported data</value>
        [DataMember(Name="exportFormat", EmitDefaultValue=false)]
        public ExportFormatEnum? ExportFormat { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of view export job to be created
        /// </summary>
        /// <value>The type of view export job to be created</value>
        [DataMember(Name="viewType", EmitDefaultValue=false)]
        public ViewTypeEnum? ViewType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingExportJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportingExportJobRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingExportJobRequest" /> class.
        /// </summary>
        
        
        /// <param name="Name">The user supplied name of the export request (required).</param>
        
        
        
        /// <param name="TimeZone">The requested timezone of the exported data (required).</param>
        
        
        
        /// <param name="ExportFormat">The requested format of the exported data (required).</param>
        
        
        
        /// <param name="Interval">The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        
        
        
        /// <param name="DataColumns">The data columns included in the export (required).</param>
        
        
        
        /// <param name="Period">The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
        
        
        
        /// <param name="ViewType">The type of view export job to be created (required).</param>
        
        
        
        /// <param name="Filter">Filters to apply to create the view (required).</param>
        
        
        
        /// <param name="Read">Indicates if the request has been marked as read.</param>
        
        
        public ReportingExportJobRequest(string Name = null, TimeZone TimeZone = null, ExportFormatEnum? ExportFormat = null, string Interval = null, List<DataColumn> DataColumns = null, string Period = null, ViewTypeEnum? ViewType = null, ViewFilter Filter = null, bool? Read = null)
        {
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ReportingExportJobRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "TimeZone" is required (not null)
            if (TimeZone == null)
            {
                throw new InvalidDataException("TimeZone is a required property for ReportingExportJobRequest and cannot be null");
            }
            else
            {
                this.TimeZone = TimeZone;
            }
            
            
            
            
            
            // to ensure "ExportFormat" is required (not null)
            if (ExportFormat == null)
            {
                throw new InvalidDataException("ExportFormat is a required property for ReportingExportJobRequest and cannot be null");
            }
            else
            {
                this.ExportFormat = ExportFormat;
            }
            
            
            
            
            
            
            
            
            
            // to ensure "DataColumns" is required (not null)
            if (DataColumns == null)
            {
                throw new InvalidDataException("DataColumns is a required property for ReportingExportJobRequest and cannot be null");
            }
            else
            {
                this.DataColumns = DataColumns;
            }
            
            
            
            
            
            
            
            
            
            // to ensure "ViewType" is required (not null)
            if (ViewType == null)
            {
                throw new InvalidDataException("ViewType is a required property for ReportingExportJobRequest and cannot be null");
            }
            else
            {
                this.ViewType = ViewType;
            }
            
            
            
            
            
            // to ensure "Filter" is required (not null)
            if (Filter == null)
            {
                throw new InvalidDataException("Filter is a required property for ReportingExportJobRequest and cannot be null");
            }
            else
            {
                this.Filter = Filter;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Interval = Interval;
            
            
            
            
            
            
            
            
            
            
            
            
this.Period = Period;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Read = Read;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The user supplied name of the export request
        /// </summary>
        /// <value>The user supplied name of the export request</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The requested timezone of the exported data
        /// </summary>
        /// <value>The requested timezone of the exported data</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public TimeZone TimeZone { get; set; }
        
        
        
        
        
        /// <summary>
        /// The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        
        
        
        /// <summary>
        /// The data columns included in the export
        /// </summary>
        /// <value>The data columns included in the export</value>
        [DataMember(Name="dataColumns", EmitDefaultValue=false)]
        public List<DataColumn> DataColumns { get; set; }
        
        
        
        /// <summary>
        /// The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }
        
        
        
        
        
        /// <summary>
        /// Filters to apply to create the view
        /// </summary>
        /// <value>Filters to apply to create the view</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public ViewFilter Filter { get; set; }
        
        
        
        /// <summary>
        /// Indicates if the request has been marked as read
        /// </summary>
        /// <value>Indicates if the request has been marked as read</value>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingExportJobRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            
            sb.Append("  ExportFormat: ").Append(ExportFormat).Append("\n");
            
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            
            sb.Append("  DataColumns: ").Append(DataColumns).Append("\n");
            
            sb.Append("  Period: ").Append(Period).Append("\n");
            
            sb.Append("  ViewType: ").Append(ViewType).Append("\n");
            
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            
            sb.Append("  Read: ").Append(Read).Append("\n");
            
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
            return this.Equals(obj as ReportingExportJobRequest);
        }

        /// <summary>
        /// Returns true if ReportingExportJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingExportJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingExportJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.ExportFormat == other.ExportFormat ||
                    this.ExportFormat != null &&
                    this.ExportFormat.Equals(other.ExportFormat)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.DataColumns == other.DataColumns ||
                    this.DataColumns != null &&
                    this.DataColumns.SequenceEqual(other.DataColumns)
                ) &&
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) &&
                (
                    this.ViewType == other.ViewType ||
                    this.ViewType != null &&
                    this.ViewType.Equals(other.ViewType)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                
                if (this.ExportFormat != null)
                    hash = hash * 59 + this.ExportFormat.GetHashCode();
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.DataColumns != null)
                    hash = hash * 59 + this.DataColumns.GetHashCode();
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                if (this.ViewType != null)
                    hash = hash * 59 + this.ViewType.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                
                return hash;
            }
        }
    }

}
