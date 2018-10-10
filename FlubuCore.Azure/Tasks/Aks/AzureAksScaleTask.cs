
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksScaleTask : ExternalProcessTaskBase<AzureAksScaleTask>
     {
        
        /// <summary>
        /// Scale the node pool in a managed Kubernetes cluster.
        /// </summary>
        public AzureAksScaleTask(string name = null ,  string nodeCount = null ,  string resourceGroup = null)
        {
            WithArguments("az aks scale");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--node-count");
            if (!string.IsNullOrEmpty(nodeCount))
            {
                 WithArguments(nodeCount);
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
        public AzureAksScaleTask NoWait(string noWait = null)
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
