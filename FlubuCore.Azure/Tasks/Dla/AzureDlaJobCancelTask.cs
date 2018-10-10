
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaJobCancelTask : ExternalProcessTaskBase<AzureDlaJobCancelTask>
     {
        
        /// <summary>
        /// Cancel a Data Lake Analytics job.
        /// </summary>
        public AzureDlaJobCancelTask(string account = null ,  string jobIdentity = null)
        {
            WithArguments("az dla job cancel");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--job-identity");
            if (!string.IsNullOrEmpty(jobIdentity))
            {
                 WithArguments(jobIdentity);
            }

        }

        protected override string Description { get; set; }
        
     }
}
