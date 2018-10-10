
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableRouteTask : ExternalProcessTaskBase<AzureNetworkRouteTableRouteTask>
     {
        
        /// <summary>
        /// Manage routes in a route table.
        /// </summary>
        public AzureNetworkRouteTableRouteTask()
        {
            WithArguments("az network route-table route");
        }

        protected override string Description { get; set; }
        
     }
}
