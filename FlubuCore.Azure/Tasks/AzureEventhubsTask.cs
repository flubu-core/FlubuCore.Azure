
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureEventhubsTask : ExternalProcessTaskBase<AzureEventhubsTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.
        /// </summary>
        public AzureEventhubsTask()
        {
            WithArguments("az eventhubs");
        }

        protected override string Description { get; set; }
        
     }
}
