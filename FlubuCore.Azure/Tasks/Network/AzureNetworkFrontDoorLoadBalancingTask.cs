
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorLoadBalancingTask : ExternalProcessTaskBase<AzureNetworkFrontDoorLoadBalancingTask>
     {
        
        /// <summary>
        /// Manage FrontDoor load-balancing settings.
        /// </summary>
        public AzureNetworkFrontDoorLoadBalancingTask()
        {
            WithArguments("az network front-door load-balancing");
        }

        protected override string Description { get; set; }
        
     }
}
