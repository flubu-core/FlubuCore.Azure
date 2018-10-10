
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSecretTask : ExternalProcessTaskBase<AzureKeyvaultSecretTask>
     {
        
        /// <summary>
        /// Manage secrets.
        /// </summary>
        public AzureKeyvaultSecretTask()
        {
            WithArguments("az keyvault secret");
        }

        protected override string Description { get; set; }
        
     }
}
