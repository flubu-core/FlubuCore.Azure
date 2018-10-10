
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchServiceCreateTask : ExternalProcessTaskBase<AzureSearchServiceCreateTask>
     {
        
        /// <summary>
        /// Creates a Search service in the given resource group.
        /// </summary>
        public AzureSearchServiceCreateTask(string name = null ,  string resourceGroup = null ,  string sku = null)
        {
            WithArguments("az search service create");
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

WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureSearchServiceCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Number of partitions in the search service.
        /// </summary>
        public AzureSearchServiceCreateTask PartitionCount(string partitionCount = null)
        {
            WithArguments("--partition-count");
            if (!string.IsNullOrEmpty(partitionCount))
            {
                 WithArguments(partitionCount);
            }

            return this;
        }

        /// <summary>
        /// Number of replicas in the search service.
        /// </summary>
        public AzureSearchServiceCreateTask ReplicaCount(string replicaCount = null)
        {
            WithArguments("--replica-count");
            if (!string.IsNullOrEmpty(replicaCount))
            {
                 WithArguments(replicaCount);
            }

            return this;
        }
     }
}
