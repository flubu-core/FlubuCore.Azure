
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageQueueTask : ExternalProcessTaskBase<AzureStorageQueueTask>
     {
        
        /// <summary>
        /// Manage storage queues.
        /// </summary>
        public AzureStorageQueueTask()
        {
            WithArguments("az storage queue");
        }

        protected override string Description { get; set; }
        
     }
}
