
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayNamespaceAuthorizationRuleTask : ExternalProcessTaskBase<AzureRelayNamespaceAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service Namespace Authorization Rule.
        /// </summary>
        public AzureRelayNamespaceAuthorizationRuleTask()
        {
            WithArguments("az relay namespace authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
