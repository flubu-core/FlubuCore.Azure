
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountTask : ExternalProcessTaskBase<AzureBatchAccountTask>
     {
        
        /// <summary>
        /// Manage Azure Batch accounts.
        /// </summary>
        public AzureBatchAccountTask()
        {
            WithArguments("az batch account");
        }

        protected override string Description { get; set; }
        
     }
}
