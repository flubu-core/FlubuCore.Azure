
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePortTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePortTask>
     {
        
        /// <summary>
        /// Manage ExpressRoute ports.
        /// </summary>
        public AzureNetworkExpressRoutePortTask()
        {
            WithArguments("az network express-route port");
        }

        protected override string Description { get; set; }
        
     }
}
