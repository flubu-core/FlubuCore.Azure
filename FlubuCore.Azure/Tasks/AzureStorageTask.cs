
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureStorageTask : ExternalProcessTaskBase<AzureStorageTask>
     {
        
        /// <summary>
        /// Manage Azure Cloud Storage resources.
        /// </summary>
        public AzureStorageTask()
        {
            WithArguments("az storage");
        }

        protected override string Description { get; set; }
        
     }
}
