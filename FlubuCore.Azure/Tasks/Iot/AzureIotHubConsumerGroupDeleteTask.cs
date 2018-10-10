
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubConsumerGroupDeleteTask : ExternalProcessTaskBase<AzureIotHubConsumerGroupDeleteTask>
     {
        
        /// <summary>
        /// Delete an event hub consumer group.
        /// </summary>
        public AzureIotHubConsumerGroupDeleteTask(string hubName = null ,  string name = null)
        {
            WithArguments("az iot hub consumer-group delete");
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
        public AzureIotHubConsumerGroupDeleteTask EventHubName(string eventHubName = null)
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
        public AzureIotHubConsumerGroupDeleteTask ResourceGroup(string resourceGroup = null)
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
