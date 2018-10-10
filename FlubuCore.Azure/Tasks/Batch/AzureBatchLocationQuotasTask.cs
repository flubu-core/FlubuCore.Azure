
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchLocationQuotasTask : ExternalProcessTaskBase<AzureBatchLocationQuotasTask>
     {
        
        /// <summary>
        /// Manage Batch service quotas at the region level.
        /// </summary>
        public AzureBatchLocationQuotasTask()
        {
            WithArguments("az batch location quotas");
        }

        protected override string Description { get; set; }
        
     }
}
