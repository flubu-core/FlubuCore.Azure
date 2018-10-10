
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubAuthorizationRuleTask : ExternalProcessTaskBase<AzureEventhubsEventhubAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Authorizationrule for Eventhub.
        /// </summary>
        public AzureEventhubsEventhubAuthorizationRuleTask()
        {
            WithArguments("az eventhubs eventhub authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
