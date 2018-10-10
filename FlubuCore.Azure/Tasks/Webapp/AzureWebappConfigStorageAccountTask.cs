
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigStorageAccountTask : ExternalProcessTaskBase<AzureWebappConfigStorageAccountTask>
     {
        
        /// <summary>
        /// Manage a web app's Azure storage account configurations.
        /// </summary>
        public AzureWebappConfigStorageAccountTask()
        {
            WithArguments("az webapp config storage-account");
        }

        protected override string Description { get; set; }
        
     }
}
