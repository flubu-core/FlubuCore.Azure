
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobNodeTask : ExternalProcessTaskBase<AzureBatchaiJobNodeTask>
     {
        
        /// <summary>
        /// Commands to work with nodes which executed a job.
        /// </summary>
        public AzureBatchaiJobNodeTask()
        {
            WithArguments("az batchai job node");
        }

        protected override string Description { get; set; }
        
     }
}
