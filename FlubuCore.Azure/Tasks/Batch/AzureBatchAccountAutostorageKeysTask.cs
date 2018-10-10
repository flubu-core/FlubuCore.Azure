
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountAutostorageKeysTask : ExternalProcessTaskBase<AzureBatchAccountAutostorageKeysTask>
     {
        
        /// <summary>
        /// Manage the access keys for the auto storage account configured for a Batch account.
        /// </summary>
        public AzureBatchAccountAutostorageKeysTask()
        {
            WithArguments("az batch account autostorage-keys");
        }

        protected override string Description { get; set; }
        
     }
}
