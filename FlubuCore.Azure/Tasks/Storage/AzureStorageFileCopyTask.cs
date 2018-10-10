
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileCopyTask : ExternalProcessTaskBase<AzureStorageFileCopyTask>
     {
        
        /// <summary>
        /// Manage file copy operations.
        /// </summary>
        public AzureStorageFileCopyTask()
        {
            WithArguments("az storage file copy");
        }

        protected override string Description { get; set; }
        
     }
}
