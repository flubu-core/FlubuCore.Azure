
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLocalGatewayTask : ExternalProcessTaskBase<AzureNetworkLocalGatewayTask>
     {
        
        /// <summary>
        /// Manage local gateways.
        /// </summary>
        public AzureNetworkLocalGatewayTask()
        {
            WithArguments("az network local-gateway");
        }

        protected override string Description { get; set; }
        
     }
}
