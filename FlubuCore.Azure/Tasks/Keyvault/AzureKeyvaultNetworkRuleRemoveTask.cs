
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultNetworkRuleRemoveTask : ExternalProcessTaskBase<AzureKeyvaultNetworkRuleRemoveTask>
     {
        
        /// <summary>
        /// Removes a network rule from the network ACLs for a Key Vault.
        /// </summary>
        public AzureKeyvaultNetworkRuleRemoveTask(string name = null)
        {
            WithArguments("az keyvault network-rule remove");
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
        public AzureKeyvaultNetworkRuleRemoveTask IpAddress(string ipAddress = null)
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
        public AzureKeyvaultNetworkRuleRemoveTask ResourceGroup(string resourceGroup = null)
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
        public AzureKeyvaultNetworkRuleRemoveTask Subnet(string subnet = null)
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
        public AzureKeyvaultNetworkRuleRemoveTask VnetName(string vnetName = null)
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
