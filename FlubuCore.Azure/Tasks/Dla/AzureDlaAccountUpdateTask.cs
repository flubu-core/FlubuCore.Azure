
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountUpdateTask : ExternalProcessTaskBase<AzureDlaAccountUpdateTask>
     {
        
        /// <summary>
        /// Update a Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountUpdateTask(string account = null)
        {
            WithArguments("az dla account update");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Allow or block IPs originating from Azure through the firewall.
        /// </summary>
        public AzureDlaAccountUpdateTask AllowAzureIps(string allowAzureIps = null)
        {
            WithArguments("--allow-azure-ips");
            if (!string.IsNullOrEmpty(allowAzureIps))
            {
                 WithArguments(allowAzureIps);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable existing firewall rules.
        /// </summary>
        public AzureDlaAccountUpdateTask FirewallState(string firewallState = null)
        {
            WithArguments("--firewall-state");
            if (!string.IsNullOrEmpty(firewallState))
            {
                 WithArguments(firewallState);
            }

            return this;
        }

        /// <summary>
        /// The maximum degree of parallelism for this account.
        /// </summary>
        public AzureDlaAccountUpdateTask MaxDegreeOfParallelism(string maxDegreeOfParallelism = null)
        {
            WithArguments("--max-degree-of-parallelism");
            if (!string.IsNullOrEmpty(maxDegreeOfParallelism))
            {
                 WithArguments(maxDegreeOfParallelism);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of concurrent jobs for this account.
        /// </summary>
        public AzureDlaAccountUpdateTask MaxJobCount(string maxJobCount = null)
        {
            WithArguments("--max-job-count");
            if (!string.IsNullOrEmpty(maxJobCount))
            {
                 WithArguments(maxJobCount);
            }

            return this;
        }

        /// <summary>
        /// The number of days to retain job metadata.
        /// </summary>
        public AzureDlaAccountUpdateTask QueryStoreRetention(string queryStoreRetention = null)
        {
            WithArguments("--query-store-retention");
            if (!string.IsNullOrEmpty(queryStoreRetention))
            {
                 WithArguments(queryStoreRetention);
            }

            return this;
        }

        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountUpdateTask ResourceGroup(string resourceGroup = null)
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
        public AzureDlaAccountUpdateTask Tags(string tags = null)
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
        public AzureDlaAccountUpdateTask Tier(string tier = null)
        {
            WithArguments("--tier");
            if (!string.IsNullOrEmpty(tier))
            {
                 WithArguments(tier);
            }

            return this;
        }
     }
}
