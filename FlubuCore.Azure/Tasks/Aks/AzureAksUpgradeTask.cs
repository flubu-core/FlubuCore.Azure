
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksUpgradeTask : ExternalProcessTaskBase<AzureAksUpgradeTask>
     {
        
        /// <summary>
        /// Upgrade a managed Kubernetes cluster to a newer version.
        /// </summary>
        public AzureAksUpgradeTask(string kubernetesVersion = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks upgrade");
WithArguments("--kubernetes-version");
            if (!string.IsNullOrEmpty(kubernetesVersion))
            {
                 WithArguments(kubernetesVersion);
            }

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
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureAksUpgradeTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureAksUpgradeTask Yes(string yes = null)
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
