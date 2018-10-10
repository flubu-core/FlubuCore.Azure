
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNsgDeleteTask : ExternalProcessTaskBase<AzureNetworkNsgDeleteTask>
     {
        
        /// <summary>
        /// Delete a network security group.
        /// </summary>
        public AzureNetworkNsgDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network nsg delete");
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
