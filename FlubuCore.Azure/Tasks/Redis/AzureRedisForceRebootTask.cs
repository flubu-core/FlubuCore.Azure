
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisForceRebootTask : ExternalProcessTaskBase<AzureRedisForceRebootTask>
     {
        
        /// <summary>
        /// Reboot specified Redis node(s).
        /// </summary>
        public AzureRedisForceRebootTask(string name = null ,  string rebootType = null ,  string resourceGroup = null)
        {
            WithArguments("az redis force-reboot");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--reboot-type");
            if (!string.IsNullOrEmpty(rebootType))
            {
                 WithArguments(rebootType);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If clustering is enabled, the ID of the shard to be rebooted.
        /// </summary>
        public AzureRedisForceRebootTask ShardId(string shardId = null)
        {
            WithArguments("--shard-id");
            if (!string.IsNullOrEmpty(shardId))
            {
                 WithArguments(shardId);
            }

            return this;
        }
     }
}
