
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubRouteTask : ExternalProcessTaskBase<AzureNetworkVhubRouteTask>
     {
        
        /// <summary>
        /// Manage entries in the virtual hub route table.
        /// </summary>
        public AzureNetworkVhubRouteTask()
        {
            WithArguments("az network vhub route");
        }

        protected override string Description { get; set; }
        
     }
}
