
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVwanCreateTask : ExternalProcessTaskBase<AzureNetworkVwanCreateTask>
     {
        
        /// <summary>
        /// Create a virtual WAN.
        /// </summary>
        public AzureNetworkVwanCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vwan create");
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
        public AzureNetworkVwanCreateTask BranchToBranchTraffic(string branchToBranchTraffic = null)
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
        public AzureNetworkVwanCreateTask DisableVpnEncryption(string disableVpnEncryption = null)
        {
            WithArguments("--disable-vpn-encryption");
            if (!string.IsNullOrEmpty(disableVpnEncryption))
            {
                 WithArguments(disableVpnEncryption);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkVwanCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The office local breakout category.
        /// </summary>
        public AzureNetworkVwanCreateTask Office365Category(string office365Category = null)
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
        public AzureNetworkVwanCreateTask SecurityProviderName(string securityProviderName = null)
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
        public AzureNetworkVwanCreateTask Tags(string tags = null)
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
        public AzureNetworkVwanCreateTask VnetToVnetTraffic(string vnetToVnetTraffic = null)
        {
            WithArguments("--vnet-to-vnet-traffic");
            if (!string.IsNullOrEmpty(vnetToVnetTraffic))
            {
                 WithArguments(vnetToVnetTraffic);
            }

            return this;
        }
     }
}
