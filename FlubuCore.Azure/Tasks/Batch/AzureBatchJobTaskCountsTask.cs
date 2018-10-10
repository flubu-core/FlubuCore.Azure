
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobTaskCountsTask : ExternalProcessTaskBase<AzureBatchJobTaskCountsTask>
     {
        
        /// <summary>
        /// View the number of tasks in a Batch job and their states.
        /// </summary>
        public AzureBatchJobTaskCountsTask()
        {
            WithArguments("az batch job task-counts");
        }

        protected override string Description { get; set; }
        
     }
}
