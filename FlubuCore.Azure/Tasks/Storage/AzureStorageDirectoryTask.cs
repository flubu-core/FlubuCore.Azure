
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageDirectoryTask : ExternalProcessTaskBase<AzureStorageDirectoryTask>
     {
        
        /// <summary>
        /// Manage file storage directories.
        /// </summary>
        public AzureStorageDirectoryTask()
        {
            WithArguments("az storage directory");
        }

        protected override string Description { get; set; }
        
     }
}
