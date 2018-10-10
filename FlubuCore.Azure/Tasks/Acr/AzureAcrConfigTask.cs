
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrConfigTask : ExternalProcessTaskBase<AzureAcrConfigTask>
     {
        
        /// <summary>
        /// Configure policies for Azure Container Registries.
        /// </summary>
        public AzureAcrConfigTask()
        {
            WithArguments("az acr config");
        }

        protected override string Description { get; set; }
        
     }
}
