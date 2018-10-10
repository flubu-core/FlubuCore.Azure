
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePeeringTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePeeringTask>
     {
        
        /// <summary>
        /// Manage ExpressRoute peering of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRoutePeeringTask()
        {
            WithArguments("az network express-route peering");
        }

        protected override string Description { get; set; }
        
     }
}
