
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureServicebusQueueAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule keys for Service Bus Queue.
        /// </summary>
        public AzureServicebusQueueAuthorizationRuleKeysTask()
        {
            WithArguments("az servicebus queue authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
