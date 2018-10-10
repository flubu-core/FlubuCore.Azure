
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountKeysTask : ExternalProcessTaskBase<AzureStorageAccountKeysTask>
     {
        
        /// <summary>
        /// Manage storage account keys.
        /// </summary>
        public AzureStorageAccountKeysTask()
        {
            WithArguments("az storage account keys");
        }

        protected override string Description { get; set; }
        
     }
}
