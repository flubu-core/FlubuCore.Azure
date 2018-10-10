
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerMetadataTask : ExternalProcessTaskBase<AzureStorageContainerMetadataTask>
     {
        
        /// <summary>
        /// Manage container metadata.
        /// </summary>
        public AzureStorageContainerMetadataTask()
        {
            WithArguments("az storage container metadata");
        }

        protected override string Description { get; set; }
        
     }
}
