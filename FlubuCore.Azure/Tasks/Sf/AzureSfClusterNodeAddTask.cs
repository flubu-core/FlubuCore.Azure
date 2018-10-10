
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterNodeAddTask : ExternalProcessTaskBase<AzureSfClusterNodeAddTask>
     {
        
        /// <summary>
        /// Add nodes to a node type in a cluster.
        /// </summary>
        public AzureSfClusterNodeAddTask(string clusterName = null ,  string nodeType = null ,  string numberOfNodesToAdd = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster node add");
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

WithArguments("--number-of-nodes-to-add");
            if (!string.IsNullOrEmpty(numberOfNodesToAdd))
            {
                 WithArguments(numberOfNodesToAdd);
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
