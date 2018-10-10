
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicSubscriptionRuleTask : ExternalProcessTaskBase<AzureServicebusTopicSubscriptionRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Rule.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleTask()
        {
            WithArguments("az servicebus topic subscription rule");
        }

        protected override string Description { get; set; }
        
     }
}
