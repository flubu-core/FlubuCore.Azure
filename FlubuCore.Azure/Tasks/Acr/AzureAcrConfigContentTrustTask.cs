
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrConfigContentTrustTask : ExternalProcessTaskBase<AzureAcrConfigContentTrustTask>
     {
        
        /// <summary>
        /// Manage content-trust policy for Azure Container Registries.
        /// </summary>
        public AzureAcrConfigContentTrustTask()
        {
            WithArguments("az acr config content-trust");
        }

        protected override string Description { get; set; }
        
     }
}
