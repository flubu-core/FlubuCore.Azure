
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationTask : ExternalProcessTaskBase<AzureBatchApplicationTask>
     {
        
        /// <summary>
        /// Manage Batch applications.
        /// </summary>
        public AzureBatchApplicationTask()
        {
            WithArguments("az batch application");
        }

        protected override string Description { get; set; }
        
     }
}
