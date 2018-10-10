
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerPolicyTask : ExternalProcessTaskBase<AzureStorageContainerPolicyTask>
     {
        
        /// <summary>
        /// Manage container stored access policies.
        /// </summary>
        public AzureStorageContainerPolicyTask()
        {
            WithArguments("az storage container policy");
        }

        protected override string Description { get; set; }
        
     }
}
