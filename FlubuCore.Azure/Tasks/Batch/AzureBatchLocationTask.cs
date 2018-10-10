
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchLocationTask : ExternalProcessTaskBase<AzureBatchLocationTask>
     {
        
        /// <summary>
        /// Manage Batch service options for a subscription at the region level.
        /// </summary>
        public AzureBatchLocationTask()
        {
            WithArguments("az batch location");
        }

        protected override string Description { get; set; }
        
     }
}
