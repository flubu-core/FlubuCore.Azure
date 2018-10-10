
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountBlobStorageTask : ExternalProcessTaskBase<AzureDlaAccountBlobStorageTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage links between Data Lake Analytics accounts and Azure Storage.
        /// </summary>
        public AzureDlaAccountBlobStorageTask()
        {
            WithArguments("az dla account blob-storage");
        }

        protected override string Description { get; set; }
        
     }
}
