
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageMetricsTask : ExternalProcessTaskBase<AzureStorageMetricsTask>
     {
        
        /// <summary>
        /// Manage storage service metrics.
        /// </summary>
        public AzureStorageMetricsTask()
        {
            WithArguments("az storage metrics");
        }

        protected override string Description { get; set; }
        
     }
}
