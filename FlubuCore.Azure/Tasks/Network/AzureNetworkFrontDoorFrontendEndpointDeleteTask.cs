
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorFrontendEndpointDeleteTask : ExternalProcessTaskBase<AzureNetworkFrontDoorFrontendEndpointDeleteTask>
     {
        
        /// <summary>
        /// Delete a FrontDoor frontend endpoint.
        /// </summary>
        public AzureNetworkFrontDoorFrontendEndpointDeleteTask(string frontDoorName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door frontend-endpoint delete");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
