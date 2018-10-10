
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobLeaseTask : ExternalProcessTaskBase<AzureStorageBlobLeaseTask>
     {
        
        /// <summary>
        /// Manage storage blob leases.
        /// </summary>
        public AzureStorageBlobLeaseTask()
        {
            WithArguments("az storage blob lease");
        }

        protected override string Description { get; set; }
        
     }
}
