
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubTask : ExternalProcessTaskBase<AzureEventhubsEventhubTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs eventhub and authorization-rule.
        /// </summary>
        public AzureEventhubsEventhubTask()
        {
            WithArguments("az eventhubs eventhub");
        }

        protected override string Description { get; set; }
        
     }
}
