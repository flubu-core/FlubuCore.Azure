
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobFileTask : ExternalProcessTaskBase<AzureBatchaiJobFileTask>
     {
        
        /// <summary>
        /// Commands to list and stream files in job's output directories.
        /// </summary>
        public AzureBatchaiJobFileTask()
        {
            WithArguments("az batchai job file");
        }

        protected override string Description { get; set; }
        
     }
}
