
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceAuthorizationRuleTask : ExternalProcessTaskBase<AzureEventhubsNamespaceAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs Authorizationrule for Namespace.
        /// </summary>
        public AzureEventhubsNamespaceAuthorizationRuleTask()
        {
            WithArguments("az eventhubs namespace authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
