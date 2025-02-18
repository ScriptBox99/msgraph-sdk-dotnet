// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance {
    public class UserProcessingResult : Entity, IParsable {
        /// <summary>The date time that the workflow execution for a user completed. Value is null if the workflow hasn&apos;t completed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The number of tasks that failed in the workflow execution.</summary>
        public int? FailedTasksCount {
            get { return BackingStore?.Get<int?>("failedTasksCount"); }
            set { BackingStore?.Set("failedTasksCount", value); }
        }
        /// <summary>The processingStatus property</summary>
        public LifecycleWorkflowProcessingStatus? ProcessingStatus {
            get { return BackingStore?.Get<LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The date time that the workflow is scheduled to be executed for a user.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? ScheduledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("scheduledDateTime"); }
            set { BackingStore?.Set("scheduledDateTime", value); }
        }
        /// <summary>The date time that the workflow execution started. Value is null if the workflow execution has not started.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.User? Subject {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.User Subject {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The associated individual task execution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaskProcessingResult>? TaskProcessingResults {
            get { return BackingStore?.Get<List<TaskProcessingResult>?>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
#nullable restore
#else
        public List<TaskProcessingResult> TaskProcessingResults {
            get { return BackingStore?.Get<List<TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
#endif
        /// <summary>The total number of tasks that in the workflow execution.</summary>
        public int? TotalTasksCount {
            get { return BackingStore?.Get<int?>("totalTasksCount"); }
            set { BackingStore?.Set("totalTasksCount", value); }
        }
        /// <summary>The total number of unprocessed tasks for the workflow.</summary>
        public int? TotalUnprocessedTasksCount {
            get { return BackingStore?.Get<int?>("totalUnprocessedTasksCount"); }
            set { BackingStore?.Set("totalUnprocessedTasksCount", value); }
        }
        /// <summary>The workflowExecutionType property</summary>
        public Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionType? WorkflowExecutionType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionType?>("workflowExecutionType"); }
            set { BackingStore?.Set("workflowExecutionType", value); }
        }
        /// <summary>The version of the workflow that was executed.</summary>
        public int? WorkflowVersion {
            get { return BackingStore?.Get<int?>("workflowVersion"); }
            set { BackingStore?.Set("workflowVersion", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserProcessingResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserProcessingResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"failedTasksCount", n => { FailedTasksCount = n.GetIntValue(); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<LifecycleWorkflowProcessingStatus>(); } },
                {"scheduledDateTime", n => { ScheduledDateTime = n.GetDateTimeOffsetValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetObjectValue<Microsoft.Graph.Models.User>(Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalTasksCount", n => { TotalTasksCount = n.GetIntValue(); } },
                {"totalUnprocessedTasksCount", n => { TotalUnprocessedTasksCount = n.GetIntValue(); } },
                {"workflowExecutionType", n => { WorkflowExecutionType = n.GetEnumValue<WorkflowExecutionType>(); } },
                {"workflowVersion", n => { WorkflowVersion = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedTasksCount", FailedTasksCount);
            writer.WriteEnumValue<LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteDateTimeOffsetValue("scheduledDateTime", ScheduledDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.User>("subject", Subject);
            writer.WriteCollectionOfObjectValues<TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalTasksCount", TotalTasksCount);
            writer.WriteIntValue("totalUnprocessedTasksCount", TotalUnprocessedTasksCount);
            writer.WriteEnumValue<WorkflowExecutionType>("workflowExecutionType", WorkflowExecutionType);
            writer.WriteIntValue("workflowVersion", WorkflowVersion);
        }
    }
}
