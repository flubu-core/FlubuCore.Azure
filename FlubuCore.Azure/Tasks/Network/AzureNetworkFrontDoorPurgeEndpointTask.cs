
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorPurgeEndpointTask : ExternalProcessTaskBase<AzureNetworkFrontDoorPurgeEndpointTask>
     {
        
        /// <summary>
        /// Removes a content from Front Door.
        /// </summary>
        public AzureNetworkFrontDoorPurgeEndpointTask(string contentPaths = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door purge-endpoint");
WithArguments("--content-paths");
            if (!string.IsNullOrEmpty(contentPaths))
            {
                 WithArguments(contentPaths);
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
