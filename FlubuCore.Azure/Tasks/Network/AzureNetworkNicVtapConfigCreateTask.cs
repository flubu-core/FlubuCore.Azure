
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicVtapConfigCreateTask : ExternalProcessTaskBase<AzureNetworkNicVtapConfigCreateTask>
     {
        
        /// <summary>
        /// Create a virtual network tap configuration.
        /// </summary>
        public AzureNetworkNicVtapConfigCreateTask(string name = null ,  string nicName = null ,  string resourceGroup = null ,  string vnetTap = null)
        {
            WithArguments("az network nic vtap-config create");
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

WithArguments("--vnet-tap");
            if (!string.IsNullOrEmpty(vnetTap))
            {
                 WithArguments(vnetTap);
            }

        }

        protected override string Description { get; set; }
        
     }
}
