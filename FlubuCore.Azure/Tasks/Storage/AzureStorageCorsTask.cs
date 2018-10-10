
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageCorsTask : ExternalProcessTaskBase<AzureStorageCorsTask>
     {
        
        /// <summary>
        /// Manage storage service Cross-Origin Resource Sharing (CORS).
        /// </summary>
        public AzureStorageCorsTask()
        {
            WithArguments("az storage cors");
        }

        protected override string Description { get; set; }
        
     }
}
