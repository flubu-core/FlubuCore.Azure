
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayHycoAuthorizationRuleTask : ExternalProcessTaskBase<AzureRelayHycoAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service Hybrid Connection Authorization Rule.
        /// </summary>
        public AzureRelayHycoAuthorizationRuleTask()
        {
            WithArguments("az relay hyco authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
