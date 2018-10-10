
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicVtapConfigTask : ExternalProcessTaskBase<AzureNetworkNicVtapConfigTask>
     {
        
        /// <summary>
        /// Manage virtual network tap configurations.
        /// </summary>
        public AzureNetworkNicVtapConfigTask()
        {
            WithArguments("az network nic vtap-config");
        }

        protected override string Description { get; set; }
        
     }
}
