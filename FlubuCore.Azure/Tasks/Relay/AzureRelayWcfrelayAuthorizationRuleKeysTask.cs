
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureRelayWcfrelayAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule keys for Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleKeysTask()
        {
            WithArguments("az relay wcfrelay authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
