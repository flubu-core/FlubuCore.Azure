
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchTaskFileTask : ExternalProcessTaskBase<AzureBatchTaskFileTask>
     {
        
        /// <summary>
        /// Manage Batch task files.
        /// </summary>
        public AzureBatchTaskFileTask()
        {
            WithArguments("az batch task file");
        }

        protected override string Description { get; set; }
        
     }
}
