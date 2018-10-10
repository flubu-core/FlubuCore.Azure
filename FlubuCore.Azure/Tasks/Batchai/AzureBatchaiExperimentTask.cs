
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiExperimentTask : ExternalProcessTaskBase<AzureBatchaiExperimentTask>
     {
        
        /// <summary>
        /// Commands to manage experiments.
        /// </summary>
        public AzureBatchaiExperimentTask()
        {
            WithArguments("az batchai experiment");
        }

        protected override string Description { get; set; }
        
     }
}
