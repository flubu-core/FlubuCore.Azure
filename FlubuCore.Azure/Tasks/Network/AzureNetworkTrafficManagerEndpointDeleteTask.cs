
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerEndpointDeleteTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerEndpointDeleteTask>
     {
        
        /// <summary>
        /// Delete a traffic manager endpoint.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointDeleteTask(string name = null ,  string profileName = null ,  string resourceGroup = null ,  string type = null)
        {
            WithArguments("az network traffic-manager endpoint delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--profile-name");
            if (!string.IsNullOrEmpty(profileName))
            {
                 WithArguments(profileName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

        }

        protected override string Description { get; set; }
        
     }
}
