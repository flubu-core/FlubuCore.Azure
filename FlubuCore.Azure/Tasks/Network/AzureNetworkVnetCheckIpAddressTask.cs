
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetCheckIpAddressTask : ExternalProcessTaskBase<AzureNetworkVnetCheckIpAddressTask>
     {
        
        /// <summary>
        /// Check if a private IP address is available for use within a virtual network.
        /// </summary>
        public AzureNetworkVnetCheckIpAddressTask(string ipAddress = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet check-ip-address");
WithArguments("--ip-address");
            if (!string.IsNullOrEmpty(ipAddress))
            {
                 WithArguments(ipAddress);
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
