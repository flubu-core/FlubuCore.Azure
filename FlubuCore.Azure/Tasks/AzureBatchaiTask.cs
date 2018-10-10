
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureBatchaiTask : ExternalProcessTaskBase<AzureBatchaiTask>
     {
        
        /// <summary>
        /// Manage Batch AI resources.
        /// </summary>
        public AzureBatchaiTask()
        {
            WithArguments("az batchai");
        }

        protected override string Description { get; set; }
        
     }
}
