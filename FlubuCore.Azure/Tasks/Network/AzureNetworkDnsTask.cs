
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsTask : ExternalProcessTaskBase<AzureNetworkDnsTask>
     {
        
        /// <summary>
        /// Manage DNS domains in Azure.
        /// </summary>
        public AzureNetworkDnsTask()
        {
            WithArguments("az network dns");
        }

        protected override string Description { get; set; }
        
     }
}
