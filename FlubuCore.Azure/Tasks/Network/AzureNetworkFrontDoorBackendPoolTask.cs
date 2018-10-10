
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorBackendPoolTask : ExternalProcessTaskBase<AzureNetworkFrontDoorBackendPoolTask>
     {
        
        /// <summary>
        /// Manage FrontDoor backend pools.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolTask()
        {
            WithArguments("az network front-door backend-pool");
        }

        protected override string Description { get; set; }
        
     }
}
