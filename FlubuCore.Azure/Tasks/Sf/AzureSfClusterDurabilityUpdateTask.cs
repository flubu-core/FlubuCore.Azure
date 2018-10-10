
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterDurabilityUpdateTask : ExternalProcessTaskBase<AzureSfClusterDurabilityUpdateTask>
     {
        
        /// <summary>
        /// Update the durability tier or VM SKU of a node type in the cluster.
        /// </summary>
        public AzureSfClusterDurabilityUpdateTask(string clusterName = null ,  string durabilityLevel = null ,  string nodeType = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster durability update");
WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
            }

WithArguments("--durability-level");
            if (!string.IsNullOrEmpty(durabilityLevel))
            {
                 WithArguments(durabilityLevel);
            }

WithArguments("--node-type");
            if (!string.IsNullOrEmpty(nodeType))
            {
                 WithArguments(nodeType);
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
