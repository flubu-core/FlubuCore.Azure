
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisUpdateSettingsTask : ExternalProcessTaskBase<AzureRedisUpdateSettingsTask>
     {
        
        /// <summary>
        /// Update the settings of a Redis cache.
        /// </summary>
        public AzureRedisUpdateSettingsTask(string name = null ,  string redisConfiguration = null ,  string resourceGroup = null)
        {
            WithArguments("az redis update-settings");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--redis-configuration");
            if (!string.IsNullOrEmpty(redisConfiguration))
            {
                 WithArguments(redisConfiguration);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
