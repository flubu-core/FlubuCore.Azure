
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchTaskSubtaskTask : ExternalProcessTaskBase<AzureBatchTaskSubtaskTask>
     {
        
        /// <summary>
        /// Manage subtask information of a Batch task.
        /// </summary>
        public AzureBatchTaskSubtaskTask()
        {
            WithArguments("az batch task subtask");
        }

        protected override string Description { get; set; }
        
     }
}
