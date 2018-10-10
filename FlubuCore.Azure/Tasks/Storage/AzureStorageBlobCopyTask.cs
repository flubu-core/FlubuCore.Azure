
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobCopyTask : ExternalProcessTaskBase<AzureStorageBlobCopyTask>
     {
        
        /// <summary>
        /// Manage blob copy operations.
        /// </summary>
        public AzureStorageBlobCopyTask()
        {
            WithArguments("az storage blob copy");
        }

        protected override string Description { get; set; }
        
     }
}
