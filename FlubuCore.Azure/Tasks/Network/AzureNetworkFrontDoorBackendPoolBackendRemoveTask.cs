
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorBackendPoolBackendRemoveTask : ExternalProcessTaskBase<AzureNetworkFrontDoorBackendPoolBackendRemoveTask>
     {
        
        /// <summary>
        /// Remove a backend from a FrontDoor backend pool.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolBackendRemoveTask(string frontDoorName = null ,  string index = null ,  string poolName = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door backend-pool backend remove");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--index");
            if (!string.IsNullOrEmpty(index))
            {
                 WithArguments(index);
            }

WithArguments("--pool-name");
            if (!string.IsNullOrEmpty(poolName))
            {
                 WithArguments(poolName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
