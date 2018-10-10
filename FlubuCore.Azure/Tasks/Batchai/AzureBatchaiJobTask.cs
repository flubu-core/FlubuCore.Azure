
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobTask : ExternalProcessTaskBase<AzureBatchaiJobTask>
     {
        
        /// <summary>
        /// Commands to manage jobs.
        /// </summary>
        public AzureBatchaiJobTask()
        {
            WithArguments("az batchai job");
        }

        protected override string Description { get; set; }
        
     }
}
