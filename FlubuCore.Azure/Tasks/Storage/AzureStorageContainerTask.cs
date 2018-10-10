
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerTask : ExternalProcessTaskBase<AzureStorageContainerTask>
     {
        
        /// <summary>
        /// Manage blob storage containers.
        /// </summary>
        public AzureStorageContainerTask()
        {
            WithArguments("az storage container");
        }

        protected override string Description { get; set; }
        
     }
}
