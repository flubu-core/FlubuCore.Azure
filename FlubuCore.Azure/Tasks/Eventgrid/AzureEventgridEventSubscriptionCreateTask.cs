
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridEventSubscriptionCreateTask : ExternalProcessTaskBase<AzureEventgridEventSubscriptionCreateTask>
     {
        
        /// <summary>
        /// Create a new event subscription for an Event Grid topic or for an Azure resource.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask(string endpoint = null ,  string name = null)
        {
            WithArguments("az eventgrid event-subscription create");
WithArguments("--endpoint");
            if (!string.IsNullOrEmpty(endpoint))
            {
                 WithArguments(endpoint);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        public AzureEventgridEventSubscriptionCreateTask EndpointType(string endpointType = null)
        {
            WithArguments("--endpoint-type");
            if (!string.IsNullOrEmpty(endpointType))
            {
                 WithArguments(endpointType);
            }

            return this;
        }

        /// <summary>
        /// A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask IncludedEventTypes(string includedEventTypes = null)
        {
            WithArguments("--included-event-types");
            if (!string.IsNullOrEmpty(includedEventTypes))
            {
                 WithArguments(includedEventTypes);
            }

            return this;
        }

        /// <summary>
        /// A space-separated list of labels to associate with this event subscription.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask Labels(string labels = null)
        {
            WithArguments("--labels");
            if (!string.IsNullOrEmpty(labels))
            {
                 WithArguments(labels);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Fully qualified identifier of the Azure resource to which the event subscription needs to be created.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask ResourceId(string resourceId = null)
        {
            WithArguments("--resource-id");
            if (!string.IsNullOrEmpty(resourceId))
            {
                 WithArguments(resourceId);
            }

            return this;
        }

        /// <summary>
        /// An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask SubjectBeginsWith(string subjectBeginsWith = null)
        {
            WithArguments("--subject-begins-with");
            if (!string.IsNullOrEmpty(subjectBeginsWith))
            {
                 WithArguments(subjectBeginsWith);
            }

            return this;
        }

        /// <summary>
        /// Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask SubjectCaseSensitive(string subjectCaseSensitive = null)
        {
            WithArguments("--subject-case-sensitive");
            if (!string.IsNullOrEmpty(subjectCaseSensitive))
            {
                 WithArguments(subjectCaseSensitive);
            }

            return this;
        }

        /// <summary>
        /// An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask SubjectEndsWith(string subjectEndsWith = null)
        {
            WithArguments("--subject-ends-with");
            if (!string.IsNullOrEmpty(subjectEndsWith))
            {
                 WithArguments(subjectEndsWith);
            }

            return this;
        }

        /// <summary>
        /// Name of the Event Grid topic to which the event subscription needs to be created.
        /// </summary>
        public AzureEventgridEventSubscriptionCreateTask TopicName(string topicName = null)
        {
            WithArguments("--topic-name");
            if (!string.IsNullOrEmpty(topicName))
            {
                 WithArguments(topicName);
            }

            return this;
        }
     }
}
