
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteAuthTask : ExternalProcessTaskBase<AzureNetworkExpressRouteAuthTask>
     {
        
        /// <summary>
        /// Manage authentication of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRouteAuthTask()
        {
            WithArguments("az network express-route auth");
        }

        protected override string Description { get; set; }
        
     }
}
