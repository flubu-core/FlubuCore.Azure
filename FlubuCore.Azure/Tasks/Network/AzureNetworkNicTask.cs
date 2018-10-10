
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicTask : ExternalProcessTaskBase<AzureNetworkNicTask>
     {
        
        /// <summary>
        /// Manage network interfaces.
        /// </summary>
        public AzureNetworkNicTask()
        {
            WithArguments("az network nic");
        }

        protected override string Description { get; set; }
        
     }
}
