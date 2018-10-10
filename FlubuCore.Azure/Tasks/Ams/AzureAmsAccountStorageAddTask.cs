
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountStorageAddTask : ExternalProcessTaskBase<AzureAmsAccountStorageAddTask>
     {
        
        /// <summary>
        /// Attach a secondary storage to an Azure Media Services account.
        /// </summary>
        public AzureAmsAccountStorageAddTask(string accountName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams account storage add");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
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
