
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicVtapConfigDeleteTask : ExternalProcessTaskBase<AzureNetworkNicVtapConfigDeleteTask>
     {
        
        /// <summary>
        /// Delete a virtual network tap configuration.
        /// </summary>
        public AzureNetworkNicVtapConfigDeleteTask(string name = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic vtap-config delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--nic-name");
            if (!string.IsNullOrEmpty(nicName))
            {
                 WithArguments(nicName);
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
