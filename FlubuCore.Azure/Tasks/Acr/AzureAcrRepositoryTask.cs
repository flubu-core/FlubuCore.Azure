
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrRepositoryTask : ExternalProcessTaskBase<AzureAcrRepositoryTask>
     {
        
        /// <summary>
        /// Manage repositories (image names) for Azure Container Registries.
        /// </summary>
        public AzureAcrRepositoryTask()
        {
            WithArguments("az acr repository");
        }

        protected override string Description { get; set; }
        
     }
}
