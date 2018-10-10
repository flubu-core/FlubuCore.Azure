
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobScheduleTask : ExternalProcessTaskBase<AzureBatchJobScheduleTask>
     {
        
        /// <summary>
        /// Manage Batch job schedules.
        /// </summary>
        public AzureBatchJobScheduleTask()
        {
            WithArguments("az batch job-schedule");
        }

        protected override string Description { get; set; }
        
     }
}
