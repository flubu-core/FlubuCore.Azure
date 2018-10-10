
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageTablePolicyTask : ExternalProcessTaskBase<AzureStorageTablePolicyTask>
     {
        
        /// <summary>
        /// Manage shared access policies of a storage table.
        /// </summary>
        public AzureStorageTablePolicyTask()
        {
            WithArguments("az storage table policy");
        }

        protected override string Description { get; set; }
        
     }
}
