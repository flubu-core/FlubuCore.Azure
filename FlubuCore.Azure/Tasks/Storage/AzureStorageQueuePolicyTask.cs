
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageQueuePolicyTask : ExternalProcessTaskBase<AzureStorageQueuePolicyTask>
     {
        
        /// <summary>
        /// Manage shared access policies for a storage queue.
        /// </summary>
        public AzureStorageQueuePolicyTask()
        {
            WithArguments("az storage queue policy");
        }

        protected override string Description { get; set; }
        
     }
}
