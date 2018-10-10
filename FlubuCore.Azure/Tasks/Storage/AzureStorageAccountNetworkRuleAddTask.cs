
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountNetworkRuleAddTask : ExternalProcessTaskBase<AzureStorageAccountNetworkRuleAddTask>
     {
        
        /// <summary>
        /// Add a network rule.
        /// </summary>
        public AzureStorageAccountNetworkRuleAddTask(string accountName = null)
        {
            WithArguments("az storage account network-rule add");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The action of virtual network rule.
        /// </summary>
        public AzureStorageAccountNetworkRuleAddTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// IPv4 address or CIDR range.
        /// </summary>
        public AzureStorageAccountNetworkRuleAddTask IpAddress(string ipAddress = null)
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
        public AzureStorageAccountNetworkRuleAddTask ResourceGroup(string resourceGroup = null)
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
        public AzureStorageAccountNetworkRuleAddTask Subnet(string subnet = null)
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
        public AzureStorageAccountNetworkRuleAddTask VnetName(string vnetName = null)
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
