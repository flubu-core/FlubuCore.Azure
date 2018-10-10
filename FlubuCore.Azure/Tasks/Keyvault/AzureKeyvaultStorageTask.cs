
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageTask : ExternalProcessTaskBase<AzureKeyvaultStorageTask>
     {
        
        /// <summary>
        /// Manage storage accounts.
        /// </summary>
        public AzureKeyvaultStorageTask()
        {
            WithArguments("az keyvault storage");
        }

        protected override string Description { get; set; }
        
     }
}
