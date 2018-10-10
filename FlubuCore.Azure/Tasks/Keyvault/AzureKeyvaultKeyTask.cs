
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyTask : ExternalProcessTaskBase<AzureKeyvaultKeyTask>
     {
        
        /// <summary>
        /// Manage keys.
        /// </summary>
        public AzureKeyvaultKeyTask()
        {
            WithArguments("az keyvault key");
        }

        protected override string Description { get; set; }
        
     }
}
