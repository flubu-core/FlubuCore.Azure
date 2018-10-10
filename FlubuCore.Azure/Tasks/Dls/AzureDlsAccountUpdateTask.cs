
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountUpdateTask : ExternalProcessTaskBase<AzureDlsAccountUpdateTask>
     {
        
        /// <summary>
        /// Updates a Data Lake Store account.
        /// </summary>
        public AzureDlsAccountUpdateTask(string account = null)
        {
            WithArguments("az dls account update");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Allow/block Azure originating IPs through the firewall.
        /// </summary>
        public AzureDlsAccountUpdateTask AllowAzureIps(string allowAzureIps = null)
        {
            WithArguments("--allow-azure-ips");
            if (!string.IsNullOrEmpty(allowAzureIps))
            {
                 WithArguments(allowAzureIps);
            }

            return this;
        }

        public AzureDlsAccountUpdateTask DefaultGroup(string defaultGroup = null)
        {
            WithArguments("--default-group");
            if (!string.IsNullOrEmpty(defaultGroup))
            {
                 WithArguments(defaultGroup);
            }

            return this;
        }

        /// <summary>
        /// Enable/disable existing firewall rules.
        /// </summary>
        public AzureDlsAccountUpdateTask FirewallState(string firewallState = null)
        {
            WithArguments("--firewall-state");
            if (!string.IsNullOrEmpty(firewallState))
            {
                 WithArguments(firewallState);
            }

            return this;
        }

        public AzureDlsAccountUpdateTask KeyVersion(string keyVersion = null)
        {
            WithArguments("--key-version");
            if (!string.IsNullOrEmpty(keyVersion))
            {
                 WithArguments(keyVersion);
            }

            return this;
        }

        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Store account.
        /// </summary>
        public AzureDlsAccountUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureDlsAccountUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The desired commitment tier for this account to use.
        /// </summary>
        public AzureDlsAccountUpdateTask Tier(string tier = null)
        {
            WithArguments("--tier");
            if (!string.IsNullOrEmpty(tier))
            {
                 WithArguments(tier);
            }

            return this;
        }

        /// <summary>
        /// Enable/disable the existing trusted ID providers.
        /// </summary>
        public AzureDlsAccountUpdateTask TrustedIdProviderState(string trustedIdProviderState = null)
        {
            WithArguments("--trusted-id-provider-state");
            if (!string.IsNullOrEmpty(trustedIdProviderState))
            {
                 WithArguments(trustedIdProviderState);
            }

            return this;
        }
     }
}
