
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubConsumerGroupTask : ExternalProcessTaskBase<AzureIotHubConsumerGroupTask>
     {
        
        /// <summary>
        /// Manage the event hub consumer groups of an IoT hub.
        /// </summary>
        public AzureIotHubConsumerGroupTask()
        {
            WithArguments("az iot hub consumer-group");
        }

        protected override string Description { get; set; }
        
     }
}
