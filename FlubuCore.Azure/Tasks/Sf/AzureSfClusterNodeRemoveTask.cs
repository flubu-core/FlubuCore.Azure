
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterNodeRemoveTask : ExternalProcessTaskBase<AzureSfClusterNodeRemoveTask>
     {
        
        /// <summary>
        /// Remove nodes from a node type in a cluster.
        /// </summary>
        public AzureSfClusterNodeRemoveTask(string clusterName = null ,  string nodeType = null ,  string numberOfNodesToRemove = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster node remove");
WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
            }

WithArguments("--node-type");
            if (!string.IsNullOrEmpty(nodeType))
            {
                 WithArguments(nodeType);
            }

WithArguments("--number-of-nodes-to-remove");
            if (!string.IsNullOrEmpty(numberOfNodesToRemove))
            {
                 WithArguments(numberOfNodesToRemove);
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
