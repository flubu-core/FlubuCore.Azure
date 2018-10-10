
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorBackendPoolBackendTask : ExternalProcessTaskBase<AzureNetworkFrontDoorBackendPoolBackendTask>
     {
        
        /// <summary>
        /// Manage backends of FrontDoor backend pools.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolBackendTask()
        {
            WithArguments("az network front-door backend-pool backend");
        }

        protected override string Description { get; set; }
        
     }
}
