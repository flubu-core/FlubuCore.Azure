
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationSummaryTask : ExternalProcessTaskBase<AzureBatchApplicationSummaryTask>
     {
        
        /// <summary>
        /// View a summary of Batch application packages.
        /// </summary>
        public AzureBatchApplicationSummaryTask()
        {
            WithArguments("az batch application summary");
        }

        protected override string Description { get; set; }
        
     }
}
