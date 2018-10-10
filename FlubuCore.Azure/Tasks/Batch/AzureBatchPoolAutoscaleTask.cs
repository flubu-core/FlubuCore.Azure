
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolAutoscaleTask : ExternalProcessTaskBase<AzureBatchPoolAutoscaleTask>
     {
        
        /// <summary>
        /// Manage automatic scaling of Batch pools.
        /// </summary>
        public AzureBatchPoolAutoscaleTask()
        {
            WithArguments("az batch pool autoscale");
        }

        protected override string Description { get; set; }
        
     }
}
