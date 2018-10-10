
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkPublicIpPrefixTask : ExternalProcessTaskBase<AzureNetworkPublicIpPrefixTask>
     {
        
        /// <summary>
        /// Manage public IP prefix resources.
        /// </summary>
        public AzureNetworkPublicIpPrefixTask()
        {
            WithArguments("az network public-ip prefix");
        }

        protected override string Description { get; set; }
        
     }
}
