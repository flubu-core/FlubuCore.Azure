
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureEventhubsNamespaceAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs Authorizationrule connection strings for Namespace.
        /// </summary>
        public AzureEventhubsNamespaceAuthorizationRuleKeysTask()
        {
            WithArguments("az eventhubs namespace authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
