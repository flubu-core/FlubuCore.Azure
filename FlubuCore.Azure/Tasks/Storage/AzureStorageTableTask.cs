
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageTableTask : ExternalProcessTaskBase<AzureStorageTableTask>
     {
        
        /// <summary>
        /// Manage NoSQL key-value storage.
        /// </summary>
        public AzureStorageTableTask()
        {
            WithArguments("az storage table");
        }

        protected override string Description { get; set; }
        
     }
}
