
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileTask : ExternalProcessTaskBase<AzureStorageFileTask>
     {
        
        /// <summary>
        /// Manage file shares that use the SMB 3.0 protocol.
        /// </summary>
        public AzureStorageFileTask()
        {
            WithArguments("az storage file");
        }

        protected override string Description { get; set; }
        
     }
}
