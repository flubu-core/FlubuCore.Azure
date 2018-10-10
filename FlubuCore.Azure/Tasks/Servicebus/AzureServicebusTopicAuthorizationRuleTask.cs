
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicAuthorizationRuleTask : ExternalProcessTaskBase<AzureServicebusTopicAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Topic Authorization Rule.
        /// </summary>
        public AzureServicebusTopicAuthorizationRuleTask()
        {
            WithArguments("az servicebus topic authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
