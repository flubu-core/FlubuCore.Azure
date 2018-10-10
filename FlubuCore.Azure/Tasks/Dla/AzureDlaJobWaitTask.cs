
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaJobWaitTask : ExternalProcessTaskBase<AzureDlaJobWaitTask>
     {
        
        /// <summary>
        /// Wait for a Data Lake Analytics job to finish.
        /// </summary>
        public AzureDlaJobWaitTask(string account = null ,  string jobId = null)
        {
            WithArguments("az dla job wait");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--job-id");
            if (!string.IsNullOrEmpty(jobId))
            {
                 WithArguments(jobId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The maximum amount of time to wait before erroring out. Default value is to never timeout. Any value <= 0 means never timeout.
        /// </summary>
        public AzureDlaJobWaitTask MaxWaitTimeSec(string maxWaitTimeSec = null)
        {
            WithArguments("--max-wait-time-sec");
            if (!string.IsNullOrEmpty(maxWaitTimeSec))
            {
                 WithArguments(maxWaitTimeSec);
            }

            return this;
        }

        /// <summary>
        /// The polling interval between checks for the job status, in seconds.
        /// </summary>
        public AzureDlaJobWaitTask WaitIntervalSec(string waitIntervalSec = null)
        {
            WithArguments("--wait-interval-sec");
            if (!string.IsNullOrEmpty(waitIntervalSec))
            {
                 WithArguments(waitIntervalSec);
            }

            return this;
        }
     }
}
