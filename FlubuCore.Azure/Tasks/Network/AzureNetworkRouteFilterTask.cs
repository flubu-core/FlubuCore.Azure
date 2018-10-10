
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteFilterTask : ExternalProcessTaskBase<AzureNetworkRouteFilterTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage route filters.
        /// </summary>
        public AzureNetworkRouteFilterTask()
        {
            WithArguments("az network route-filter");
        }

        protected override string Description { get; set; }
        
     }
}
