
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultNetworkRuleAddTask : ExternalProcessTaskBase<AzureKeyvaultNetworkRuleAddTask>
     {
        
        /// <summary>
        /// Add a network rule to the network ACLs for a Key Vault.
        /// </summary>
        public AzureKeyvaultNetworkRuleAddTask(string name = null)
        {
            WithArguments("az keyvault network-rule add");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IPv4 address or CIDR range.
        /// </summary>
        public AzureKeyvaultNetworkRuleAddTask IpAddress(string ipAddress = null)
        {
            WithArguments("--ip-address");
            if (!string.IsNullOrEmpty(ipAddress))
            {
                 WithArguments(ipAddress);
            }

            return this;
        }

        /// <summary>
        /// Proceed only if Key Vault belongs to the specified resource group.
        /// </summary>
        public AzureKeyvaultNetworkRuleAddTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.
        /// </summary>
        public AzureKeyvaultNetworkRuleAddTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// Name of a virtual network.
        /// </summary>
        public AzureKeyvaultNetworkRuleAddTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }
     }
}
