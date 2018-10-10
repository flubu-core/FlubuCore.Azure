
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksEnableAddonsTask : ExternalProcessTaskBase<AzureAksEnableAddonsTask>
     {
        
        /// <summary>
        /// Enable Kubernetes addons.
        /// </summary>
        public AzureAksEnableAddonsTask(string addons = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks enable-addons");
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
        public AzureAksEnableAddonsTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.
        /// </summary>
        public AzureAksEnableAddonsTask WorkspaceResourceId(string workspaceResourceId = null)
        {
            WithArguments("--workspace-resource-id");
            if (!string.IsNullOrEmpty(workspaceResourceId))
            {
                 WithArguments(workspaceResourceId);
            }

            return this;
        }
     }
}
