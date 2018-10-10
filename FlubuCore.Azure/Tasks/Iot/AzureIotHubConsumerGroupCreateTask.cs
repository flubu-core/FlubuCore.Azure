
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubConsumerGroupCreateTask : ExternalProcessTaskBase<AzureIotHubConsumerGroupCreateTask>
     {
        
        /// <summary>
        /// Create an event hub consumer group.
        /// </summary>
        public AzureIotHubConsumerGroupCreateTask(string hubName = null ,  string name = null)
        {
            WithArguments("az iot hub consumer-group create");
WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Event hub endpoint name.
        /// </summary>
        public AzureIotHubConsumerGroupCreateTask EventHubName(string eventHubName = null)
        {
            WithArguments("--event-hub-name");
            if (!string.IsNullOrEmpty(eventHubName))
            {
                 WithArguments(eventHubName);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubConsumerGroupCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
