
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubConnectionTask : ExternalProcessTaskBase<AzureNetworkVhubConnectionTask>
     {
        
        /// <summary>
        /// Manage virtual hub VNet connections.
        /// </summary>
        public AzureNetworkVhubConnectionTask()
        {
            WithArguments("az network vhub connection");
        }

        protected override string Description { get; set; }
        
     }
}
