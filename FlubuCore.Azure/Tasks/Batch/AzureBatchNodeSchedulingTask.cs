
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeSchedulingTask : ExternalProcessTaskBase<AzureBatchNodeSchedulingTask>
     {
        
        /// <summary>
        /// Manage task scheduling for a Batch compute node.
        /// </summary>
        public AzureBatchNodeSchedulingTask()
        {
            WithArguments("az batch node scheduling");
        }

        protected override string Description { get; set; }
        
     }
}
