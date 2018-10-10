
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerEndpointTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerEndpointTask>
     {
        
        /// <summary>
        /// Manage Azure Traffic Manager end points.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointTask()
        {
            WithArguments("az network traffic-manager endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
