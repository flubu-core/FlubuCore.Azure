
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayHycoAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureRelayHycoAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Authorization Rule of the given Relay Service Hybrid Connection.
        /// </summary>
        public AzureRelayHycoAuthorizationRuleDeleteTask(string hybridConnectionName = null ,  string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay hyco authorization-rule delete");
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
        
     }
}
