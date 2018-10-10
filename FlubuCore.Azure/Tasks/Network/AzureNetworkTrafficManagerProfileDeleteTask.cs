
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerProfileDeleteTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerProfileDeleteTask>
     {
        
        /// <summary>
        /// Delete a traffic manager profile.
        /// </summary>
        public AzureNetworkTrafficManagerProfileDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network traffic-manager profile delete");
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
