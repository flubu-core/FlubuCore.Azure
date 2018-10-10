
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigDeleteTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigDeleteTask>
     {
        
        /// <summary>
        /// Delete an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigDeleteTask(string name = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic ip-config delete");
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
