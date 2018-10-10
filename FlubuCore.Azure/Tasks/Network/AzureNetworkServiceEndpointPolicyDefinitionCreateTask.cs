
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkServiceEndpointPolicyDefinitionCreateTask : ExternalProcessTaskBase<AzureNetworkServiceEndpointPolicyDefinitionCreateTask>
     {
        
        /// <summary>
        /// Create a service endpoint policy definition.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionCreateTask(string name = null ,  string policyName = null ,  string resourceGroup = null ,  string service = null ,  string serviceResources = null)
        {
            WithArguments("az network service-endpoint policy-definition create");
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

WithArguments("--service");
            if (!string.IsNullOrEmpty(service))
            {
                 WithArguments(service);
            }

WithArguments("--service-resources");
            if (!string.IsNullOrEmpty(serviceResources))
            {
                 WithArguments(serviceResources);
            }

        }

        protected override string Description { get; set; }
        
     }
}
