
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionTask>
     {
        
        /// <summary>
        /// Manage customers' ExpressRoute circuits.
        /// </summary>
        public AzureNetworkCrossConnectionTask()
        {
            WithArguments("az network cross-connection");
        }

        protected override string Description { get; set; }
        
     }
}
