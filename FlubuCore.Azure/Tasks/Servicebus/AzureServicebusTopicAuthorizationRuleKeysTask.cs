
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureServicebusTopicAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule keys for Service Bus Topic.
        /// </summary>
        public AzureServicebusTopicAuthorizationRuleKeysTask()
        {
            WithArguments("az servicebus topic authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
