
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksGetVersionsTask : ExternalProcessTaskBase<AzureAksGetVersionsTask>
     {
        
        /// <summary>
        /// Get the versions available for creating a managed Kubernetes cluster.
        /// </summary>
        public AzureAksGetVersionsTask(string location = null)
        {
            WithArguments("az aks get-versions");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

        }

        protected override string Description { get; set; }
        
     }
}
