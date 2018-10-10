
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageDirectoryMetadataTask : ExternalProcessTaskBase<AzureStorageDirectoryMetadataTask>
     {
        
        /// <summary>
        /// Manage file storage directory metadata.
        /// </summary>
        public AzureStorageDirectoryMetadataTask()
        {
            WithArguments("az storage directory metadata");
        }

        protected override string Description { get; set; }
        
     }
}
