
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueAuthorizationRuleTask : ExternalProcessTaskBase<AzureServicebusQueueAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Queue Authorization Rule.
        /// </summary>
        public AzureServicebusQueueAuthorizationRuleTask()
        {
            WithArguments("az servicebus queue authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
