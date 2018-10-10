
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkServiceEndpointTask : ExternalProcessTaskBase<AzureNetworkServiceEndpointTask>
     {
        
        /// <summary>
        /// Manage policies related to service endpoints.
        /// </summary>
        public AzureNetworkServiceEndpointTask()
        {
            WithArguments("az network service-endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
