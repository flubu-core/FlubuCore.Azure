
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisCreateTask : ExternalProcessTaskBase<AzureRedisCreateTask>
     {
        
        /// <summary>
        /// Create new Redis Cache instance.
        /// </summary>
        public AzureRedisCreateTask(string location = null ,  string name = null ,  string resourceGroup = null ,  string sku = null ,  string vmSize = null)
        {
            WithArguments("az redis create");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

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

WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

WithArguments("--vm-size");
            if (!string.IsNullOrEmpty(vmSize))
            {
                 WithArguments(vmSize);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If the value is true, then the non-ssl redis server port (6379) will be enabled.
        /// </summary>
        public AzureRedisCreateTask EnableNonSslPort(string enableNonSslPort = null)
        {
            WithArguments("--enable-non-ssl-port");
            if (!string.IsNullOrEmpty(enableNonSslPort))
            {
                 WithArguments(enableNonSslPort);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded configuration settings. Use @{file} to load from a file.
        /// </summary>
        public AzureRedisCreateTask RedisConfiguration(string redisConfiguration = null)
        {
            WithArguments("--redis-configuration");
            if (!string.IsNullOrEmpty(redisConfiguration))
            {
                 WithArguments(redisConfiguration);
            }

            return this;
        }

        /// <summary>
        /// The number of shards to be created on a Premium Cluster Cache.
        /// </summary>
        public AzureRedisCreateTask ShardCount(string shardCount = null)
        {
            WithArguments("--shard-count");
            if (!string.IsNullOrEmpty(shardCount))
            {
                 WithArguments(shardCount);
            }

            return this;
        }

        /// <summary>
        /// Required when deploying a redis cache inside an existing Azure Virtual Network.
        /// </summary>
        public AzureRedisCreateTask StaticIp(string staticIp = null)
        {
            WithArguments("--static-ip");
            if (!string.IsNullOrEmpty(staticIp))
            {
                 WithArguments(staticIp);
            }

            return this;
        }

        /// <summary>
        /// The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.
        /// </summary>
        public AzureRedisCreateTask SubnetId(string subnetId = null)
        {
            WithArguments("--subnet-id");
            if (!string.IsNullOrEmpty(subnetId))
            {
                 WithArguments(subnetId);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureRedisCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Json dictionary with tenant settings.
        /// </summary>
        public AzureRedisCreateTask TenantSettings(string tenantSettings = null)
        {
            WithArguments("--tenant-settings");
            if (!string.IsNullOrEmpty(tenantSettings))
            {
                 WithArguments(tenantSettings);
            }

            return this;
        }
     }
}
