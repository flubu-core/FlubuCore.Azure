
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeTask : ExternalProcessTaskBase<AzureBatchNodeTask>
     {
        
        /// <summary>
        /// Manage Batch compute nodes.
        /// </summary>
        public AzureBatchNodeTask()
        {
            WithArguments("az batch node");
        }

        protected override string Description { get; set; }
        
     }
}
