
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbCreateTask : ExternalProcessTaskBase<AzureCosmosdbCreateTask>
     {
        
        /// <summary>
        /// Creates a new Azure Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cosmosdb create");
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
        /// Set custom capabilities on the Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbCreateTask Capabilities(string capabilities = null)
        {
            WithArguments("--capabilities");
            if (!string.IsNullOrEmpty(capabilities))
            {
                 WithArguments(capabilities);
            }

            return this;
        }

        /// <summary>
        /// Default consistency level of the Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbCreateTask DefaultConsistencyLevel(string defaultConsistencyLevel = null)
        {
            WithArguments("--default-consistency-level");
            if (!string.IsNullOrEmpty(defaultConsistencyLevel))
            {
                 WithArguments(defaultConsistencyLevel);
            }

            return this;
        }

        /// <summary>
        /// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
        /// </summary>
        public AzureCosmosdbCreateTask EnableAutomaticFailover(string enableAutomaticFailover = null)
        {
            WithArguments("--enable-automatic-failover");
            if (!string.IsNullOrEmpty(enableAutomaticFailover))
            {
                 WithArguments(enableAutomaticFailover);
            }

            return this;
        }

        /// <summary>
        /// Enables virtual network on the Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbCreateTask EnableVirtualNetwork(string enableVirtualNetwork = null)
        {
            WithArguments("--enable-virtual-network");
            if (!string.IsNullOrEmpty(enableVirtualNetwork))
            {
                 WithArguments(enableVirtualNetwork);
            }

            return this;
        }

        /// <summary>
        /// Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.
        /// </summary>
        public AzureCosmosdbCreateTask IpRangeFilter(string ipRangeFilter = null)
        {
            WithArguments("--ip-range-filter");
            if (!string.IsNullOrEmpty(ipRangeFilter))
            {
                 WithArguments(ipRangeFilter);
            }

            return this;
        }

        /// <summary>
        /// The type of Cosmos DB database account to create.
        /// </summary>
        public AzureCosmosdbCreateTask Kind(string kind = null)
        {
            WithArguments("--kind");
            if (!string.IsNullOrEmpty(kind))
            {
                 WithArguments(kind);
            }

            return this;
        }

        /// <summary>
        /// Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.
        /// </summary>
        public AzureCosmosdbCreateTask Locations(string locations = null)
        {
            WithArguments("--locations");
            if (!string.IsNullOrEmpty(locations))
            {
                 WithArguments(locations);
            }

            return this;
        }

        /// <summary>
        /// When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.
        /// </summary>
        public AzureCosmosdbCreateTask MaxInterval(string maxInterval = null)
        {
            WithArguments("--max-interval");
            if (!string.IsNullOrEmpty(maxInterval))
            {
                 WithArguments(maxInterval);
            }

            return this;
        }

        /// <summary>
        /// When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.
        /// </summary>
        public AzureCosmosdbCreateTask MaxStalenessPrefix(string maxStalenessPrefix = null)
        {
            WithArguments("--max-staleness-prefix");
            if (!string.IsNullOrEmpty(maxStalenessPrefix))
            {
                 WithArguments(maxStalenessPrefix);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureCosmosdbCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// ACL's for virtual network.
        /// </summary>
        public AzureCosmosdbCreateTask VirtualNetworkRules(string virtualNetworkRules = null)
        {
            WithArguments("--virtual-network-rules");
            if (!string.IsNullOrEmpty(virtualNetworkRules))
            {
                 WithArguments(virtualNetworkRules);
            }

            return this;
        }
     }
}
