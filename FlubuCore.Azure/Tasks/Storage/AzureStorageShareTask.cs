
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageShareTask : ExternalProcessTaskBase<AzureStorageShareTask>
     {
        
        /// <summary>
        /// Manage file shares.
        /// </summary>
        public AzureStorageShareTask()
        {
            WithArguments("az storage share");
        }

        protected override string Description { get; set; }
        
     }
}
