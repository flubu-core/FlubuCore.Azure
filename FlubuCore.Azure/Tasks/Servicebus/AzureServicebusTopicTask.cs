
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicTask : ExternalProcessTaskBase<AzureServicebusTopicTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Topic and Authorization Rule.
        /// </summary>
        public AzureServicebusTopicTask()
        {
            WithArguments("az servicebus topic");
        }

        protected override string Description { get; set; }
        
     }
}
