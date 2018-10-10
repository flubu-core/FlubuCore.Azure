
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAcrTask : ExternalProcessTaskBase<AzureAcrTask>
     {
        
        /// <summary>
        /// Manage private registries with Azure Container Registries.
        /// </summary>
        public AzureAcrTask()
        {
            WithArguments("az acr");
        }

        protected override string Description { get; set; }
        
     }
}
