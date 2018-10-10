
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrCredentialTask : ExternalProcessTaskBase<AzureAcrCredentialTask>
     {
        
        /// <summary>
        /// Manage login credentials for Azure Container Registries.
        /// </summary>
        public AzureAcrCredentialTask()
        {
            WithArguments("az acr credential");
        }

        protected override string Description { get; set; }
        
     }
}
