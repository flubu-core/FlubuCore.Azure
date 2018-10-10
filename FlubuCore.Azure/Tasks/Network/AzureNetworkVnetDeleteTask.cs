
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetDeleteTask : ExternalProcessTaskBase<AzureNetworkVnetDeleteTask>
     {
        
        /// <summary>
        /// Delete a virtual network.
        /// </summary>
        public AzureNetworkVnetDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet delete");
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
