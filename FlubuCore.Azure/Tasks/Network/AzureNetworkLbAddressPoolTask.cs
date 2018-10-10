
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbAddressPoolTask : ExternalProcessTaskBase<AzureNetworkLbAddressPoolTask>
     {
        
        /// <summary>
        /// Manage address pools of a load balancer.
        /// </summary>
        public AzureNetworkLbAddressPoolTask()
        {
            WithArguments("az network lb address-pool");
        }

        protected override string Description { get; set; }
        
     }
}
