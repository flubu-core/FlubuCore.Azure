
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchFileTask : ExternalProcessTaskBase<AzureBatchFileTask>
     {
        
        /// <summary>
        /// Manage Batch input files.
        /// </summary>
        public AzureBatchFileTask()
        {
            WithArguments("az batch file");
        }

        protected override string Description { get; set; }
        
     }
}
