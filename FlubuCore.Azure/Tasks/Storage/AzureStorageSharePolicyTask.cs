
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageSharePolicyTask : ExternalProcessTaskBase<AzureStorageSharePolicyTask>
     {
        
        /// <summary>
        /// Manage shared access policies of a storage file share.
        /// </summary>
        public AzureStorageSharePolicyTask()
        {
            WithArguments("az storage share policy");
        }

        protected override string Description { get; set; }
        
     }
}
