
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeFileTask : ExternalProcessTaskBase<AzureBatchNodeFileTask>
     {
        
        /// <summary>
        /// Manage Batch compute node files.
        /// </summary>
        public AzureBatchNodeFileTask()
        {
            WithArguments("az batch node file");
        }

        protected override string Description { get; set; }
        
     }
}
