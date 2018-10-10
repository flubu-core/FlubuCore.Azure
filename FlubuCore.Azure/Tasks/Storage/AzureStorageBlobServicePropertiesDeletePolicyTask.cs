
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobServicePropertiesDeletePolicyTask : ExternalProcessTaskBase<AzureStorageBlobServicePropertiesDeletePolicyTask>
     {
        
        /// <summary>
        /// Manage storage blob delete-policy service properties.
        /// </summary>
        public AzureStorageBlobServicePropertiesDeletePolicyTask()
        {
            WithArguments("az storage blob service-properties delete-policy");
        }

        protected override string Description { get; set; }
        
     }
}
