
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVwanUpdateTask : ExternalProcessTaskBase<AzureNetworkVwanUpdateTask>
     {
        
        /// <summary>
        /// Update settings of a virtual WAN.
        /// </summary>
        public AzureNetworkVwanUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vwan update");
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
        
        /// <summary>
        /// Allow branch-to-branch traffic flow.
        /// </summary>
        public AzureNetworkVwanUpdateTask BranchToBranchTraffic(string branchToBranchTraffic = null)
        {
            WithArguments("--branch-to-branch-traffic");
            if (!string.IsNullOrEmpty(branchToBranchTraffic))
            {
                 WithArguments(branchToBranchTraffic);
            }

            return this;
        }

        /// <summary>
        /// State of VPN encryption.
        /// </summary>
        public AzureNetworkVwanUpdateTask DisableVpnEncryption(string disableVpnEncryption = null)
        {
            WithArguments("--disable-vpn-encryption");
            if (!string.IsNullOrEmpty(disableVpnEncryption))
            {
                 WithArguments(disableVpnEncryption);
            }

            return this;
        }

        /// <summary>
        /// The office local breakout category.
        /// </summary>
        public AzureNetworkVwanUpdateTask Office365Category(string office365Category = null)
        {
            WithArguments("--office365-category");
            if (!string.IsNullOrEmpty(office365Category))
            {
                 WithArguments(office365Category);
            }

            return this;
        }

        /// <summary>
        /// The security provider name.
        /// </summary>
        public AzureNetworkVwanUpdateTask SecurityProviderName(string securityProviderName = null)
        {
            WithArguments("--security-provider-name");
            if (!string.IsNullOrEmpty(securityProviderName))
            {
                 WithArguments(securityProviderName);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVwanUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Allow VNet-to-VNet traffic flow.
        /// </summary>
        public AzureNetworkVwanUpdateTask VnetToVnetTraffic(string vnetToVnetTraffic = null)
        {
            WithArguments("--vnet-to-vnet-traffic");
            if (!string.IsNullOrEmpty(vnetToVnetTraffic))
            {
                 WithArguments(vnetToVnetTraffic);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVwanUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkVwanUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkVwanUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkVwanUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
