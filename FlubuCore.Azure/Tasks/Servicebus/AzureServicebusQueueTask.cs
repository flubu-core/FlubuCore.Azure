
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueTask : ExternalProcessTaskBase<AzureServicebusQueueTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Queue and Authorization Rule.
        /// </summary>
        public AzureServicebusQueueTask()
        {
            WithArguments("az servicebus queue");
        }

        protected override string Description { get; set; }
        
     }
}
