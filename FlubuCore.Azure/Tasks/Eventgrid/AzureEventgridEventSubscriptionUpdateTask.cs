
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridEventSubscriptionUpdateTask : ExternalProcessTaskBase<AzureEventgridEventSubscriptionUpdateTask>
     {
        
        /// <summary>
        /// Update an event subscription.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask(string name = null)
        {
            WithArguments("az eventgrid event-subscription update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask Endpoint(string endpoint = null)
        {
            WithArguments("--endpoint");
            if (!string.IsNullOrEmpty(endpoint))
            {
                 WithArguments(endpoint);
            }

            return this;
        }

        public AzureEventgridEventSubscriptionUpdateTask EndpointType(string endpointType = null)
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
        public AzureEventgridEventSubscriptionUpdateTask IncludedEventTypes(string includedEventTypes = null)
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
        public AzureEventgridEventSubscriptionUpdateTask Labels(string labels = null)
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
        public AzureEventgridEventSubscriptionUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Fully qualified identifier of the Azure resource.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask ResourceId(string resourceId = null)
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
        public AzureEventgridEventSubscriptionUpdateTask SubjectBeginsWith(string subjectBeginsWith = null)
        {
            WithArguments("--subject-begins-with");
            if (!string.IsNullOrEmpty(subjectBeginsWith))
            {
                 WithArguments(subjectBeginsWith);
            }

            return this;
        }

        /// <summary>
        /// An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask SubjectEndsWith(string subjectEndsWith = null)
        {
            WithArguments("--subject-ends-with");
            if (!string.IsNullOrEmpty(subjectEndsWith))
            {
                 WithArguments(subjectEndsWith);
            }

            return this;
        }

        /// <summary>
        /// Name of the Event Grid topic.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask TopicName(string topicName = null)
        {
            WithArguments("--topic-name");
            if (!string.IsNullOrEmpty(topicName))
            {
                 WithArguments(topicName);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureEventgridEventSubscriptionUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
