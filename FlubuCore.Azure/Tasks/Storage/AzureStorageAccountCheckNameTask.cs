
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountCheckNameTask : ExternalProcessTaskBase<AzureStorageAccountCheckNameTask>
     {
        
        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// </summary>
        public AzureStorageAccountCheckNameTask(string name = null)
        {
            WithArguments("az storage account check-name");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
