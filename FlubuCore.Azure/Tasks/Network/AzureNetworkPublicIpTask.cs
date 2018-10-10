
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkPublicIpTask : ExternalProcessTaskBase<AzureNetworkPublicIpTask>
     {
        
        /// <summary>
        /// Manage public IP addresses.
        /// </summary>
        public AzureNetworkPublicIpTask()
        {
            WithArguments("az network public-ip");
        }

        protected override string Description { get; set; }
        
     }
}
