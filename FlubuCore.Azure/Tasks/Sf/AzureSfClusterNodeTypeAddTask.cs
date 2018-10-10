
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterNodeTypeAddTask : ExternalProcessTaskBase<AzureSfClusterNodeTypeAddTask>
     {
        
        /// <summary>
        /// Add a new node type to a cluster.
        /// </summary>
        public AzureSfClusterNodeTypeAddTask(string capacity = null ,  string clusterName = null ,  string nodeType = null ,  string resourceGroup = null ,  string vmPassword = null ,  string vmUserName = null)
        {
            WithArguments("az sf cluster node-type add");
WithArguments("--capacity");
            if (!string.IsNullOrEmpty(capacity))
            {
                 WithArguments(capacity);
            }

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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vm-password");
            if (!string.IsNullOrEmpty(vmPassword))
            {
                 WithArguments(vmPassword);
            }

WithArguments("--vm-user-name");
            if (!string.IsNullOrEmpty(vmUserName))
            {
                 WithArguments(vmUserName);
            }

        }

        protected override string Description { get; set; }
        
        public AzureSfClusterNodeTypeAddTask DurabilityLevel(string durabilityLevel = null)
        {
            WithArguments("--durability-level");
            if (!string.IsNullOrEmpty(durabilityLevel))
            {
                 WithArguments(durabilityLevel);
            }

            return this;
        }

        /// <summary>
        /// The Vm Sku.
        /// </summary>
        public AzureSfClusterNodeTypeAddTask VmSku(string vmSku = null)
        {
            WithArguments("--vm-sku");
            if (!string.IsNullOrEmpty(vmSku))
            {
                 WithArguments(vmSku);
            }

            return this;
        }

        public AzureSfClusterNodeTypeAddTask VmTier(string vmTier = null)
        {
            WithArguments("--vm-tier");
            if (!string.IsNullOrEmpty(vmTier))
            {
                 WithArguments(vmTier);
            }

            return this;
        }
     }
}
