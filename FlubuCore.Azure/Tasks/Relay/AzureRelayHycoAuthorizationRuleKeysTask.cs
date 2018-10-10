
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayHycoAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureRelayHycoAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule keys for Relay Service Hybrid Connection.
        /// </summary>
        public AzureRelayHycoAuthorizationRuleKeysTask()
        {
            WithArguments("az relay hyco authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
