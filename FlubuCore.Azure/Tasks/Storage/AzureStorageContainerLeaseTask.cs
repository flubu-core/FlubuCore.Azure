
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerLeaseTask : ExternalProcessTaskBase<AzureStorageContainerLeaseTask>
     {
        
        /// <summary>
        /// Manage blob storage container leases.
        /// </summary>
        public AzureStorageContainerLeaseTask()
        {
            WithArguments("az storage container lease");
        }

        protected override string Description { get; set; }
        
     }
}
