
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageShareMetadataTask : ExternalProcessTaskBase<AzureStorageShareMetadataTask>
     {
        
        /// <summary>
        /// Manage the metadata of a file share.
        /// </summary>
        public AzureStorageShareMetadataTask()
        {
            WithArguments("az storage share metadata");
        }

        protected override string Description { get; set; }
        
     }
}
