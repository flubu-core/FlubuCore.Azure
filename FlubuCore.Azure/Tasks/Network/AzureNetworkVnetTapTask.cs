
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetTapTask : ExternalProcessTaskBase<AzureNetworkVnetTapTask>
     {
        
        /// <summary>
        /// Manage virtual network taps.
        /// </summary>
        public AzureNetworkVnetTapTask()
        {
            WithArguments("az network vnet tap");
        }

        protected override string Description { get; set; }
        
     }
}
