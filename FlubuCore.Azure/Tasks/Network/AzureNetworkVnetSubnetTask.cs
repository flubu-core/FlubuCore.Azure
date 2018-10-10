
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetSubnetTask : ExternalProcessTaskBase<AzureNetworkVnetSubnetTask>
     {
        
        /// <summary>
        /// Manage subnets in an Azure Virtual Network.
        /// </summary>
        public AzureNetworkVnetSubnetTask()
        {
            WithArguments("az network vnet subnet");
        }

        protected override string Description { get; set; }
        
     }
}
