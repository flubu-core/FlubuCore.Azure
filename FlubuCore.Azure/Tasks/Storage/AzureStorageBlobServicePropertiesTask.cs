
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobServicePropertiesTask : ExternalProcessTaskBase<AzureStorageBlobServicePropertiesTask>
     {
        
        /// <summary>
        /// Manage storage blob service properties.
        /// </summary>
        public AzureStorageBlobServicePropertiesTask()
        {
            WithArguments("az storage blob service-properties");
        }

        protected override string Description { get; set; }
        
     }
}
