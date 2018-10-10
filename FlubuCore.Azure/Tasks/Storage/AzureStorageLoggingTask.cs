
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageLoggingTask : ExternalProcessTaskBase<AzureStorageLoggingTask>
     {
        
        /// <summary>
        /// Manage storage service logging information.
        /// </summary>
        public AzureStorageLoggingTask()
        {
            WithArguments("az storage logging");
        }

        protected override string Description { get; set; }
        
     }
}
