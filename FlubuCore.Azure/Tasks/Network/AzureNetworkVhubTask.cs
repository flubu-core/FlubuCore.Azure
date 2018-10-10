
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubTask : ExternalProcessTaskBase<AzureNetworkVhubTask>
     {
        
        /// <summary>
        /// Manage virtual hubs.
        /// </summary>
        public AzureNetworkVhubTask()
        {
            WithArguments("az network vhub");
        }

        protected override string Description { get; set; }
        
     }
}
