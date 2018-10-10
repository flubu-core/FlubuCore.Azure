
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubConsumerGroupTask : ExternalProcessTaskBase<AzureEventhubsEventhubConsumerGroupTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs consumergroup.
        /// </summary>
        public AzureEventhubsEventhubConsumerGroupTask()
        {
            WithArguments("az eventhubs eventhub consumer-group");
        }

        protected override string Description { get; set; }
        
     }
}
