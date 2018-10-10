
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolUsageMetricsTask : ExternalProcessTaskBase<AzureBatchPoolUsageMetricsTask>
     {
        
        /// <summary>
        /// View usage metrics of Batch pools.
        /// </summary>
        public AzureBatchPoolUsageMetricsTask()
        {
            WithArguments("az batch pool usage-metrics");
        }

        protected override string Description { get; set; }
        
     }
}
