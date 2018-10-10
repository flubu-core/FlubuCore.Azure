
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerLegalHoldTask : ExternalProcessTaskBase<AzureStorageContainerLegalHoldTask>
     {
        
        /// <summary>
        /// Manage container legal holds.
        /// </summary>
        public AzureStorageContainerLegalHoldTask()
        {
            WithArguments("az storage container legal-hold");
        }

        protected override string Description { get; set; }
        
     }
}
