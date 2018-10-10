
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureBatchTask : ExternalProcessTaskBase<AzureBatchTask>
     {
        
        /// <summary>
        /// Manage Azure Batch.
        /// </summary>
        public AzureBatchTask()
        {
            WithArguments("az batch");
        }

        protected override string Description { get; set; }
        
     }
}
