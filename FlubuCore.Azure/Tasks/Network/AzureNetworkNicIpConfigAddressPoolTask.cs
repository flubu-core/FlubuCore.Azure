
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigAddressPoolTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigAddressPoolTask>
     {
        
        /// <summary>
        /// Manage address pools in an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigAddressPoolTask()
        {
            WithArguments("az network nic ip-config address-pool");
        }

        protected override string Description { get; set; }
        
     }
}
