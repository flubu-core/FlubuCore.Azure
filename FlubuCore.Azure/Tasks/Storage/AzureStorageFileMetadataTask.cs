
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileMetadataTask : ExternalProcessTaskBase<AzureStorageFileMetadataTask>
     {
        
        /// <summary>
        /// Manage file metadata.
        /// </summary>
        public AzureStorageFileMetadataTask()
        {
            WithArguments("az storage file metadata");
        }

        protected override string Description { get; set; }
        
     }
}
