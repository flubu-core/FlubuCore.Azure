
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetSubnetDeleteTask : ExternalProcessTaskBase<AzureNetworkVnetSubnetDeleteTask>
     {
        
        /// <summary>
        /// Delete a subnet.
        /// </summary>
        public AzureNetworkVnetSubnetDeleteTask(string name = null ,  string resourceGroup = null ,  string vnetName = null)
        {
            WithArguments("az network vnet subnet delete");
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

WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
