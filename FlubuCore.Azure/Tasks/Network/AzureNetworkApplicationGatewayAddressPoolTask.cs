
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayAddressPoolTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayAddressPoolTask>
     {
        
        /// <summary>
        /// Manage address pools of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayAddressPoolTask()
        {
            WithArguments("az network application-gateway address-pool");
        }

        protected override string Description { get; set; }
        
     }
}
