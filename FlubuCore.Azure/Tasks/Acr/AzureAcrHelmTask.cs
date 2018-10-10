
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrHelmTask : ExternalProcessTaskBase<AzureAcrHelmTask>
     {
        
        /// <summary>
        /// Manage helm charts for Azure Container Registries.
        /// </summary>
        public AzureAcrHelmTask()
        {
            WithArguments("az acr helm");
        }

        protected override string Description { get; set; }
        
     }
}
