
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobPrepReleaseStatusTask : ExternalProcessTaskBase<AzureBatchJobPrepReleaseStatusTask>
     {
        
        /// <summary>
        /// View the status of Batch job preparation and release tasks.
        /// </summary>
        public AzureBatchJobPrepReleaseStatusTask()
        {
            WithArguments("az batch job prep-release-status");
        }

        protected override string Description { get; set; }
        
     }
}
