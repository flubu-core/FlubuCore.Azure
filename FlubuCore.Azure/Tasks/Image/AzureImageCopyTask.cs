
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Image
{
     public partial class AzureImageCopyTask : ExternalProcessTaskBase<AzureImageCopyTask>
     {
        
        /// <summary>
        /// Copy a managed image (or vm) to other regions.
        /// </summary>
        public AzureImageCopyTask(string sourceObjectName = null ,  string sourceResourceGroup = null ,  string targetLocation = null ,  string targetResourceGroup = null)
        {
            WithArguments("az image copy");
WithArguments("--source-object-name");
            if (!string.IsNullOrEmpty(sourceObjectName))
            {
                 WithArguments(sourceObjectName);
            }

WithArguments("--source-resource-group");
            if (!string.IsNullOrEmpty(sourceResourceGroup))
            {
                 WithArguments(sourceResourceGroup);
            }

WithArguments("--target-location");
            if (!string.IsNullOrEmpty(targetLocation))
            {
                 WithArguments(targetLocation);
            }

WithArguments("--target-resource-group");
            if (!string.IsNullOrEmpty(targetResourceGroup))
            {
                 WithArguments(targetResourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Include this switch to delete temporary resources upon completion.
        /// </summary>
        public AzureImageCopyTask Cleanup(string cleanup = null)
        {
            WithArguments("--cleanup");
            if (!string.IsNullOrEmpty(cleanup))
            {
                 WithArguments(cleanup);
            }

            return this;
        }

        /// <summary>
        /// Number of parallel copy operations.
        /// </summary>
        public AzureImageCopyTask ParallelDegree(string parallelDegree = null)
        {
            WithArguments("--parallel-degree");
            if (!string.IsNullOrEmpty(parallelDegree))
            {
                 WithArguments(parallelDegree);
            }

            return this;
        }

        /// <summary>
        /// Image or vm.
        /// </summary>
        public AzureImageCopyTask SourceType(string sourceType = null)
        {
            WithArguments("--source-type");
            if (!string.IsNullOrEmpty(sourceType))
            {
                 WithArguments(sourceType);
            }

            return this;
        }

        public AzureImageCopyTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Name of the final image that will be created.
        /// </summary>
        public AzureImageCopyTask TargetName(string targetName = null)
        {
            WithArguments("--target-name");
            if (!string.IsNullOrEmpty(targetName))
            {
                 WithArguments(targetName);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the subscription where the final image should be created.
        /// </summary>
        public AzureImageCopyTask TargetSubscription(string targetSubscription = null)
        {
            WithArguments("--target-subscription");
            if (!string.IsNullOrEmpty(targetSubscription))
            {
                 WithArguments(targetSubscription);
            }

            return this;
        }
     }
}
