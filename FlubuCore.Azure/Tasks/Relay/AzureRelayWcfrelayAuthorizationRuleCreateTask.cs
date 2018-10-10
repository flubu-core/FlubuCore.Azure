
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayAuthorizationRuleCreateTask : ExternalProcessTaskBase<AzureRelayWcfrelayAuthorizationRuleCreateTask>
     {
        
        /// <summary>
        /// Create Authorization Rule for the given Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleCreateTask(string name = null ,  string namespaceName = null ,  string relayName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay wcfrelay authorization-rule create");
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
        
        /// <summary>
        /// Space-separated list of Authorization rule rights.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleCreateTask Rights(string rights = null)
        {
            WithArguments("--rights");
            if (!string.IsNullOrEmpty(rights))
            {
                 WithArguments(rights);
            }

            return this;
        }
     }
}
