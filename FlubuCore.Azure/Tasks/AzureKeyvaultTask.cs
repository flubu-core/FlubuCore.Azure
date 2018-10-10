
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureKeyvaultTask : ExternalProcessTaskBase<AzureKeyvaultTask>
     {
        
        /// <summary>
        /// Manage KeyVault keys, secrets, and certificates.
        /// </summary>
        public AzureKeyvaultTask()
        {
            WithArguments("az keyvault");
        }

        protected override string Description { get; set; }
        
     }
}
