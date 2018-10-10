
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionPeeringTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionPeeringTask>
     {
        
        /// <summary>
        /// Manage ExpressRoute peering of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringTask()
        {
            WithArguments("az network cross-connection peering");
        }

        protected override string Description { get; set; }
        
     }
}
