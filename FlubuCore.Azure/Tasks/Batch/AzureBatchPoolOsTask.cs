
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolOsTask : ExternalProcessTaskBase<AzureBatchPoolOsTask>
     {
        
        /// <summary>
        /// Manage the operating system of Batch pools.
        /// </summary>
        public AzureBatchPoolOsTask()
        {
            WithArguments("az batch pool os");
        }

        protected override string Description { get; set; }
        
     }
}
