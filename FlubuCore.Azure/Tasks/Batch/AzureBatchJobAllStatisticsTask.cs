
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobAllStatisticsTask : ExternalProcessTaskBase<AzureBatchJobAllStatisticsTask>
     {
        
        /// <summary>
        /// View statistics of all jobs under a Batch account.
        /// </summary>
        public AzureBatchJobAllStatisticsTask()
        {
            WithArguments("az batch job all-statistics");
        }

        protected override string Description { get; set; }
        
     }
}
