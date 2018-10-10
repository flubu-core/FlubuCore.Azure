
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVwanTask : ExternalProcessTaskBase<AzureNetworkVwanTask>
     {
        
        /// <summary>
        /// Manage virtual WANs.
        /// </summary>
        public AzureNetworkVwanTask()
        {
            WithArguments("az network vwan");
        }

        protected override string Description { get; set; }
        
     }
}
