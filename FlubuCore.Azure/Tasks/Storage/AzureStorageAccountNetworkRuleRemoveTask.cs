
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountNetworkRuleRemoveTask : ExternalProcessTaskBase<AzureStorageAccountNetworkRuleRemoveTask>
     {
        
        /// <summary>
        /// Remove a network rule.
        /// </summary>
        public AzureStorageAccountNetworkRuleRemoveTask(string accountName = null)
        {
            WithArguments("az storage account network-rule remove");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IPv4 address or CIDR range.
        /// </summary>
        public AzureStorageAccountNetworkRuleRemoveTask IpAddress(string ipAddress = null)
        {
            WithArguments("--ip-address");
            if (!string.IsNullOrEmpty(ipAddress))
            {
                 WithArguments(ipAddress);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureStorageAccountNetworkRuleRemoveTask ResourceGroup(string resourceGroup = null)
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
        public AzureStorageAccountNetworkRuleRemoveTask Subnet(string subnet = null)
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
        public AzureStorageAccountNetworkRuleRemoveTask VnetName(string vnetName = null)
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
