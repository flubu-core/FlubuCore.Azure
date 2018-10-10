
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountKeysRenewTask : ExternalProcessTaskBase<AzureBatchAccountKeysRenewTask>
     {
        
        /// <summary>
        /// Regenerates the specified account key for the Batch account.
        /// </summary>
        public AzureBatchAccountKeysRenewTask(string keyName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch account keys renew");
WithArguments("--key-name");
            if (!string.IsNullOrEmpty(keyName))
            {
                 WithArguments(keyName);
            }

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
