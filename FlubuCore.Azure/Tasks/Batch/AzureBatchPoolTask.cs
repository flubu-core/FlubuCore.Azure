
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolTask : ExternalProcessTaskBase<AzureBatchPoolTask>
     {
        
        /// <summary>
        /// Manage Batch pools.
        /// </summary>
        public AzureBatchPoolTask()
        {
            WithArguments("az batch pool");
        }

        protected override string Description { get; set; }
        
     }
}
