
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayHycoAuthorizationRuleCreateTask : ExternalProcessTaskBase<AzureRelayHycoAuthorizationRuleCreateTask>
     {
        
        /// <summary>
        /// Create Authorization Rule for given Relay Service Hybrid Connection.
        /// </summary>
        public AzureRelayHycoAuthorizationRuleCreateTask(string hybridConnectionName = null ,  string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay hyco authorization-rule create");
WithArguments("--hybrid-connection-name");
            if (!string.IsNullOrEmpty(hybridConnectionName))
            {
                 WithArguments(hybridConnectionName);
            }

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
        public AzureRelayHycoAuthorizationRuleCreateTask Rights(string rights = null)
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
