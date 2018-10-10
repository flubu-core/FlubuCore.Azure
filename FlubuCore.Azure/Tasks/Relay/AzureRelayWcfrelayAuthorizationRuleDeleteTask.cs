
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureRelayWcfrelayAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete the Authorization Rule of Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleDeleteTask(string name = null ,  string namespaceName = null ,  string relayName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay wcfrelay authorization-rule delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--namespace-name");
            if (!string.IsNullOrEmpty(namespaceName))
            {
                 WithArguments(namespaceName);
            }

WithArguments("--relay-name");
            if (!string.IsNullOrEmpty(relayName))
            {
                 WithArguments(relayName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
