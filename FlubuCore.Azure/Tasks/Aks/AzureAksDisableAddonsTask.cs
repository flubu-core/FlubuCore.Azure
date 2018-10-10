
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksDisableAddonsTask : ExternalProcessTaskBase<AzureAksDisableAddonsTask>
     {
        
        /// <summary>
        /// Disable Kubernetes addons.
        /// </summary>
        public AzureAksDisableAddonsTask(string addons = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks disable-addons");
WithArguments("--addons");
            if (!string.IsNullOrEmpty(addons))
            {
                 WithArguments(addons);
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
        public AzureAksDisableAddonsTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
