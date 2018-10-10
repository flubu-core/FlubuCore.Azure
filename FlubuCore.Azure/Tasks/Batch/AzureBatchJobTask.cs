
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobTask : ExternalProcessTaskBase<AzureBatchJobTask>
     {
        
        /// <summary>
        /// Manage Batch jobs.
        /// </summary>
        public AzureBatchJobTask()
        {
            WithArguments("az batch job");
        }

        protected override string Description { get; set; }
        
     }
}
