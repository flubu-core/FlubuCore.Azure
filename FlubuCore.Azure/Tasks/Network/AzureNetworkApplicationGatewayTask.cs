
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayTask>
     {
        
        /// <summary>
        /// Manage application-level routing and load balancing services.
        /// </summary>
        public AzureNetworkApplicationGatewayTask()
        {
            WithArguments("az network application-gateway");
        }

        protected override string Description { get; set; }
        
     }
}
