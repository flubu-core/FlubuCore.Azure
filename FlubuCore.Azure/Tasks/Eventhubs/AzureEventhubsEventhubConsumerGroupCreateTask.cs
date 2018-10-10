
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubConsumerGroupCreateTask : ExternalProcessTaskBase<AzureEventhubsEventhubConsumerGroupCreateTask>
     {
        
        /// <summary>
        /// Creates the EventHub ConsumerGroup.
        /// </summary>
        public AzureEventhubsEventhubConsumerGroupCreateTask(string eventhubName = null ,  string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs eventhub consumer-group create");
WithArguments("--eventhub-name");
            if (!string.IsNullOrEmpty(eventhubName))
            {
                 WithArguments(eventhubName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--namespace-name");
            if (!string.IsNullOrEmpty(namespaceName))
            {
                 WithArguments(namespaceName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.
        /// </summary>
        public AzureEventhubsEventhubConsumerGroupCreateTask UserMetadata(string userMetadata = null)
        {
            WithArguments("--user-metadata");
            if (!string.IsNullOrEmpty(userMetadata))
            {
                 WithArguments(userMetadata);
            }

            return this;
        }
     }
}
