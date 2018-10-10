
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetTask : ExternalProcessTaskBase<AzureNetworkVnetTask>
     {
        
        /// <summary>
        /// Manage Azure Virtual Networks.
        /// </summary>
        public AzureNetworkVnetTask()
        {
            WithArguments("az network vnet");
        }

        protected override string Description { get; set; }
        
     }
}
