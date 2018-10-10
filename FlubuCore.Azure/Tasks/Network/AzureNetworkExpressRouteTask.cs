
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteTask : ExternalProcessTaskBase<AzureNetworkExpressRouteTask>
     {
        
        /// <summary>
        /// Manage dedicated private network fiber connections to Azure.
        /// </summary>
        public AzureNetworkExpressRouteTask()
        {
            WithArguments("az network express-route");
        }

        protected override string Description { get; set; }
        
     }
}
