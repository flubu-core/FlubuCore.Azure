
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisPatchScheduleDeleteTask : ExternalProcessTaskBase<AzureRedisPatchScheduleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the patching schedule of a redis cache (requires Premium SKU).
        /// </summary>
        public AzureRedisPatchScheduleDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az redis patch-schedule delete");
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
