
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisPatchScheduleTask : ExternalProcessTaskBase<AzureRedisPatchScheduleTask>
     {
        
        /// <summary>
        /// Manage Redis patch schedules.
        /// </summary>
        public AzureRedisPatchScheduleTask()
        {
            WithArguments("az redis patch-schedule");
        }

        protected override string Description { get; set; }
        
     }
}
