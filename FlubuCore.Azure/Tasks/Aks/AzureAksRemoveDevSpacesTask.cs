
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksRemoveDevSpacesTask : ExternalProcessTaskBase<AzureAksRemoveDevSpacesTask>
     {
        
        /// <summary>
        /// (PREVIEW) Remove Azure Dev Spaces from a managed Kubernetes cluster.
        /// </summary>
        public AzureAksRemoveDevSpacesTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks remove-dev-spaces");
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
        
        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureAksRemoveDevSpacesTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
