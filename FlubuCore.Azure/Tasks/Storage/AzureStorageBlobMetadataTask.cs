
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobMetadataTask : ExternalProcessTaskBase<AzureStorageBlobMetadataTask>
     {
        
        /// <summary>
        /// Manage blob metadata.
        /// </summary>
        public AzureStorageBlobMetadataTask()
        {
            WithArguments("az storage blob metadata");
        }

        protected override string Description { get; set; }
        
     }
}
