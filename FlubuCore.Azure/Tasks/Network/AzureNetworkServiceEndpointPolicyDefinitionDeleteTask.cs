
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkServiceEndpointPolicyDefinitionDeleteTask : ExternalProcessTaskBase<AzureNetworkServiceEndpointPolicyDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Delete a service endpoint policy definition.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionDeleteTask(string name = null ,  string policyName = null ,  string resourceGroup = null)
        {
            WithArguments("az network service-endpoint policy-definition delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--policy-name");
            if (!string.IsNullOrEmpty(policyName))
            {
                 WithArguments(policyName);
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
