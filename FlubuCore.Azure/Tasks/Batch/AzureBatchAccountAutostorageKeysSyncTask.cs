
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountAutostorageKeysSyncTask : ExternalProcessTaskBase<AzureBatchAccountAutostorageKeysSyncTask>
     {
        
        /// <summary>
        /// Synchronizes access keys for the auto-storage account configured for the specified Batch account.
        /// </summary>
        public AzureBatchAccountAutostorageKeysSyncTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch account autostorage-keys sync");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
