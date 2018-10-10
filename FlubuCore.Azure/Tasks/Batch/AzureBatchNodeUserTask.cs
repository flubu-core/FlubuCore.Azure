
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeUserTask : ExternalProcessTaskBase<AzureBatchNodeUserTask>
     {
        
        /// <summary>
        /// Manage the user accounts of a Batch compute node.
        /// </summary>
        public AzureBatchNodeUserTask()
        {
            WithArguments("az batch node user");
        }

        protected override string Description { get; set; }
        
     }
}
