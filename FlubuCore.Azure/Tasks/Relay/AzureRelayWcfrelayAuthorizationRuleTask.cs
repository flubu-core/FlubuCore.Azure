
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayAuthorizationRuleTask : ExternalProcessTaskBase<AzureRelayWcfrelayAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service WCF Relay Authorization Rule.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleTask()
        {
            WithArguments("az relay wcfrelay authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
