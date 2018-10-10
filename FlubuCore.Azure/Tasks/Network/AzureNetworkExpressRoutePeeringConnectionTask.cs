
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePeeringConnectionTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePeeringConnectionTask>
     {
        
        /// <summary>
        /// Manage ExpressRoute circuit connections.
        /// </summary>
        public AzureNetworkExpressRoutePeeringConnectionTask()
        {
            WithArguments("az network express-route peering connection");
        }

        protected override string Description { get; set; }
        
     }
}
