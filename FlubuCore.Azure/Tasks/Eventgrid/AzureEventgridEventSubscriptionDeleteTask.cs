
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridEventSubscriptionDeleteTask : ExternalProcessTaskBase<AzureEventgridEventSubscriptionDeleteTask>
     {
        
        /// <summary>
        /// Delete an event subscription.
        /// </summary>
        public AzureEventgridEventSubscriptionDeleteTask(string name = null)
        {
            WithArguments("az eventgrid event-subscription delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureEventgridEventSubscriptionDeleteTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.
        /// </summary>
        public AzureEventgridEventSubscriptionDeleteTask ResourceId(string resourceId = null)
        {
            WithArguments("--resource-id");
            if (!string.IsNullOrEmpty(resourceId))
            {
                 WithArguments(resourceId);
            }

            return this;
        }

        /// <summary>
        /// Name of the Event Grid topic whose event subscription needs to be deleted.
        /// </summary>
        public AzureEventgridEventSubscriptionDeleteTask TopicName(string topicName = null)
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
