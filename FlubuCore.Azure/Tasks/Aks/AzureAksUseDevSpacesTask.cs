
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksUseDevSpacesTask : ExternalProcessTaskBase<AzureAksUseDevSpacesTask>
     {
        
        /// <summary>
        /// (PREVIEW) Use Azure Dev Spaces with a managed Kubernetes cluster.
        /// </summary>
        public AzureAksUseDevSpacesTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks use-dev-spaces");
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
        /// Name of the new or existing dev space to select. Defaults to an interactive selection experience.
        /// </summary>
        public AzureAksUseDevSpacesTask Space(string space = null)
        {
            WithArguments("--space");
            if (!string.IsNullOrEmpty(space))
            {
                 WithArguments(space);
            }

            return this;
        }

        /// <summary>
        /// Update to the latest Azure Dev Spaces client components.
        /// </summary>
        public AzureAksUseDevSpacesTask Update(string update = null)
        {
            WithArguments("--update");
            if (!string.IsNullOrEmpty(update))
            {
                 WithArguments(update);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation. Requires --space.
        /// </summary>
        public AzureAksUseDevSpacesTask Yes(string yes = null)
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
