
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterReliabilityUpdateTask : ExternalProcessTaskBase<AzureSfClusterReliabilityUpdateTask>
     {
        
        /// <summary>
        /// Update the reliability tier for the primary node in a cluster.
        /// </summary>
        public AzureSfClusterReliabilityUpdateTask(string clusterName = null ,  string reliabilityLevel = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster reliability update");
WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
            }

WithArguments("--reliability-level");
            if (!string.IsNullOrEmpty(reliabilityLevel))
            {
                 WithArguments(reliabilityLevel);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add node count automatically when changing reliability.
        /// </summary>
        public AzureSfClusterReliabilityUpdateTask AutoAddNode(string autoAddNode = null)
        {
            WithArguments("--auto-add-node");
            if (!string.IsNullOrEmpty(autoAddNode))
            {
                 WithArguments(autoAddNode);
            }

            return this;
        }
     }
}
