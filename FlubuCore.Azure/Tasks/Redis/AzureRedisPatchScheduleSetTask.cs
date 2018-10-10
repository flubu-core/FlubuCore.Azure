
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisPatchScheduleSetTask : ExternalProcessTaskBase<AzureRedisPatchScheduleSetTask>
     {
        
        /// <summary>
        /// Create or replace the patching schedule for Redis cache (requires Premium SKU).
        /// </summary>
        public AzureRedisPatchScheduleSetTask(string name = null ,  string resourceGroup = null ,  string scheduleEntries = null)
        {
            WithArguments("az redis patch-schedule set");
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

WithArguments("--schedule-entries");
            if (!string.IsNullOrEmpty(scheduleEntries))
            {
                 WithArguments(scheduleEntries);
            }

        }

        protected override string Description { get; set; }
        
     }
}
