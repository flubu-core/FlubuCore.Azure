
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeServiceLogsTask : ExternalProcessTaskBase<AzureBatchNodeServiceLogsTask>
     {
        
        /// <summary>
        /// Manage the service log files of a Batch compute node.
        /// </summary>
        public AzureBatchNodeServiceLogsTask()
        {
            WithArguments("az batch node service-logs");
        }

        protected override string Description { get; set; }
        
     }
}
