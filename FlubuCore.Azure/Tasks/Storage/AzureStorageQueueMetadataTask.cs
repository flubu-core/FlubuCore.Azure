
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageQueueMetadataTask : ExternalProcessTaskBase<AzureStorageQueueMetadataTask>
     {
        
        /// <summary>
        /// Manage the metadata for a storage queue.
        /// </summary>
        public AzureStorageQueueMetadataTask()
        {
            WithArguments("az storage queue metadata");
        }

        protected override string Description { get; set; }
        
     }
}
