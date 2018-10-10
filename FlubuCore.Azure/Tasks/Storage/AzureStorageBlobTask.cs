
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobTask : ExternalProcessTaskBase<AzureStorageBlobTask>
     {
        
        /// <summary>
        /// Manage object storage for unstructured data (blobs).
        /// </summary>
        public AzureStorageBlobTask()
        {
            WithArguments("az storage blob");
        }

        protected override string Description { get; set; }
        
     }
}
