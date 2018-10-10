
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePortLinkTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePortLinkTask>
     {
        
        /// <summary>
        /// View ExpressRoute links.
        /// </summary>
        public AzureNetworkExpressRoutePortLinkTask()
        {
            WithArguments("az network express-route port link");
        }

        protected override string Description { get; set; }
        
     }
}
