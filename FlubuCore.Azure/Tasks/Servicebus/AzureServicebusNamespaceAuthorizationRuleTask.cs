
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusNamespaceAuthorizationRuleTask : ExternalProcessTaskBase<AzureServicebusNamespaceAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Namespace Authorization Rule.
        /// </summary>
        public AzureServicebusNamespaceAuthorizationRuleTask()
        {
            WithArguments("az servicebus namespace authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
