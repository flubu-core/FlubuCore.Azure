
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisDeleteTask : ExternalProcessTaskBase<AzureRedisDeleteTask>
     {
        
        /// <summary>
        /// Deletes a Redis cache.
        /// </summary>
        public AzureRedisDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az redis delete");
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
        
     }
}
