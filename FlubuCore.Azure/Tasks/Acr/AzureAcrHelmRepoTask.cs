
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrHelmRepoTask : ExternalProcessTaskBase<AzureAcrHelmRepoTask>
     {
        
        /// <summary>
        /// Manage helm chart repositories for Azure Container Registries.
        /// </summary>
        public AzureAcrHelmRepoTask()
        {
            WithArguments("az acr helm repo");
        }

        protected override string Description { get; set; }
        
     }
}
