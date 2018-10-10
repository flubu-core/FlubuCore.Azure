
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigTask>
     {
        
        /// <summary>
        /// Manage IP configurations of a network interface.
        /// </summary>
        public AzureNetworkNicIpConfigTask()
        {
            WithArguments("az network nic ip-config");
        }

        protected override string Description { get; set; }
        
     }
}
