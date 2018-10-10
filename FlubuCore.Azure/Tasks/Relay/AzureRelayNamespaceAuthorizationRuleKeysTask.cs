
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayNamespaceAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureRelayNamespaceAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule connection strings for Namespace.
        /// </summary>
        public AzureRelayNamespaceAuthorizationRuleKeysTask()
        {
            WithArguments("az relay namespace authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
