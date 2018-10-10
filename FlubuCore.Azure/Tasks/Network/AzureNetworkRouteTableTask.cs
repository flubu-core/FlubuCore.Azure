
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableTask : ExternalProcessTaskBase<AzureNetworkRouteTableTask>
     {
        
        /// <summary>
        /// Manage route tables.
        /// </summary>
        public AzureNetworkRouteTableTask()
        {
            WithArguments("az network route-table");
        }

        protected override string Description { get; set; }
        
     }
}
