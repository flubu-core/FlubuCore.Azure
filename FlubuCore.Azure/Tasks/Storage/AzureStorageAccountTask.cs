
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountTask : ExternalProcessTaskBase<AzureStorageAccountTask>
     {
        
        /// <summary>
        /// Manage storage accounts.
        /// </summary>
        public AzureStorageAccountTask()
        {
            WithArguments("az storage account");
        }

        protected override string Description { get; set; }
        
     }
}
