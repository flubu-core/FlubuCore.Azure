
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageMessageTask : ExternalProcessTaskBase<AzureStorageMessageTask>
     {
        
        /// <summary>
        /// Manage queue storage messages.
        /// </summary>
        public AzureStorageMessageTask()
        {
            WithArguments("az storage message");
        }

        protected override string Description { get; set; }
        
     }
}
