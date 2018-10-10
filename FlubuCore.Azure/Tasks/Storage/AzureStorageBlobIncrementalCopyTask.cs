
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobIncrementalCopyTask : ExternalProcessTaskBase<AzureStorageBlobIncrementalCopyTask>
     {
        
        /// <summary>
        /// Manage blob incremental copy operations.
        /// </summary>
        public AzureStorageBlobIncrementalCopyTask()
        {
            WithArguments("az storage blob incremental-copy");
        }

        protected override string Description { get; set; }
        
     }
}
