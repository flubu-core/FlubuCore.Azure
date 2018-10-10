
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallIpConfigCreateTask : ExternalProcessTaskBase<AzureNetworkFirewallIpConfigCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Firewall IP configuration.
        /// </summary>
        public AzureNetworkFirewallIpConfigCreateTask(string firewallName = null ,  string name = null ,  string publicIpAddress = null ,  string resourceGroup = null ,  string vnetName = null)
        {
            WithArguments("az network firewall ip-config create");
WithArguments("--firewall-name");
            if (!string.IsNullOrEmpty(firewallName))
            {
                 WithArguments(firewallName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
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
        
        /// <summary>
        /// IP address used by the Firewall ILB as the next hop in User Defined Routes.
        /// </summary>
        public AzureNetworkFirewallIpConfigCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }
     }
}
