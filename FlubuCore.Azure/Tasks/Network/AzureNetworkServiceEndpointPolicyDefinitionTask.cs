
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkServiceEndpointPolicyDefinitionTask : ExternalProcessTaskBase<AzureNetworkServiceEndpointPolicyDefinitionTask>
     {
        
        /// <summary>
        /// Manage service endpoint policy definitions.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionTask()
        {
            WithArguments("az network service-endpoint policy-definition");
        }

        protected override string Description { get; set; }
        
     }
}
