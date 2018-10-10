
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerImmutabilityPolicyTask : ExternalProcessTaskBase<AzureStorageContainerImmutabilityPolicyTask>
     {
        
        /// <summary>
        /// Manage container immutability policies.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyTask()
        {
            WithArguments("az storage container immutability-policy");
        }

        protected override string Description { get; set; }
        
     }
}
