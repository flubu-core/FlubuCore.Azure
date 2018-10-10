
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolAllStatisticsTask : ExternalProcessTaskBase<AzureBatchPoolAllStatisticsTask>
     {
        
        /// <summary>
        /// View statistics of all pools under a Batch account.
        /// </summary>
        public AzureBatchPoolAllStatisticsTask()
        {
            WithArguments("az batch pool all-statistics");
        }

        protected override string Description { get; set; }
        
     }
}
