
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchTaskTask : ExternalProcessTaskBase<AzureBatchTaskTask>
     {
        
        /// <summary>
        /// Manage Batch tasks.
        /// </summary>
        public AzureBatchTaskTask()
        {
            WithArguments("az batch task");
        }

        protected override string Description { get; set; }
        
     }
}
