
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisRegenerateKeysTask : ExternalProcessTaskBase<AzureRedisRegenerateKeysTask>
     {
        
        /// <summary>
        /// Regenerate Redis cache's access keys.
        /// </summary>
        public AzureRedisRegenerateKeysTask(string keyType = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az redis regenerate-keys");
WithArguments("--key-type");
            if (!string.IsNullOrEmpty(keyType))
            {
                 WithArguments(keyType);
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

        }

        protected override string Description { get; set; }
        
     }
}
