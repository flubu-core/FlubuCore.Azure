
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkServiceEndpointPolicyTask : ExternalProcessTaskBase<AzureNetworkServiceEndpointPolicyTask>
     {
        
        /// <summary>
        /// Manage service endpoint policies.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyTask()
        {
            WithArguments("az network service-endpoint policy");
        }

        protected override string Description { get; set; }
        
     }
}
