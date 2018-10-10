
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksGetUpgradesTask : ExternalProcessTaskBase<AzureAksGetUpgradesTask>
     {
        
        /// <summary>
        /// Get the upgrade versions available for a managed Kubernetes cluster.
        /// </summary>
        public AzureAksGetUpgradesTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks get-upgrades");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
