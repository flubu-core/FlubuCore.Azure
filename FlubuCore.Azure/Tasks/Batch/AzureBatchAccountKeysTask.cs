
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountKeysTask : ExternalProcessTaskBase<AzureBatchAccountKeysTask>
     {
        
        /// <summary>
        /// Manage Batch account keys.
        /// </summary>
        public AzureBatchAccountKeysTask()
        {
            WithArguments("az batch account keys");
        }

        protected override string Description { get; set; }
        
     }
}
