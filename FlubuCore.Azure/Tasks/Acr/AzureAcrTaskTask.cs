
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskTask : ExternalProcessTaskBase<AzureAcrTaskTask>
     {
        
        /// <summary>
        /// Manage a collection of steps for building, testing and OS & Framework patching container images using Azure Container Registries.
        /// </summary>
        public AzureAcrTaskTask()
        {
            WithArguments("az acr task");
        }

        protected override string Description { get; set; }
        
     }
}
