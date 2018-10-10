
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePortLocationTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePortLocationTask>
     {
        
        /// <summary>
        /// View ExpressRoute port location information.
        /// </summary>
        public AzureNetworkExpressRoutePortLocationTask()
        {
            WithArguments("az network express-route port location");
        }

        protected override string Description { get; set; }
        
     }
}
