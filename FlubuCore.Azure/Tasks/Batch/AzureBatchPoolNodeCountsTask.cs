
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolNodeCountsTask : ExternalProcessTaskBase<AzureBatchPoolNodeCountsTask>
     {
        
        /// <summary>
        /// Get node counts for Batch pools.
        /// </summary>
        public AzureBatchPoolNodeCountsTask()
        {
            WithArguments("az batch pool node-counts");
        }

        protected override string Description { get; set; }
        
     }
}
