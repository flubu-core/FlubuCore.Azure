
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageVersionCreateTask : ExternalProcessTaskBase<AzureSigImageVersionCreateTask>
     {
        
        /// <summary>
        /// Creat a new image version.
        /// </summary>
        public AzureSigImageVersionCreateTask(string galleryImageDefinition = null ,  string galleryImageVersion = null ,  string galleryName = null ,  string managedImage = null ,  string resourceGroup = null)
        {
            WithArguments("az sig image-version create");
WithArguments("--gallery-image-definition");
            if (!string.IsNullOrEmpty(galleryImageDefinition))
            {
                 WithArguments(galleryImageDefinition);
            }

WithArguments("--gallery-image-version");
            if (!string.IsNullOrEmpty(galleryImageVersion))
            {
                 WithArguments(galleryImageVersion);
            }

WithArguments("--gallery-name");
            if (!string.IsNullOrEmpty(galleryName))
            {
                 WithArguments(galleryName);
            }

WithArguments("--managed-image");
            if (!string.IsNullOrEmpty(managedImage))
            {
                 WithArguments(managedImage);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The end of life date, e.g. '2020-12-31'.
        /// </summary>
        public AzureSigImageVersionCreateTask EndOfLifeDate(string endOfLifeDate = null)
        {
            WithArguments("--end-of-life-date");
            if (!string.IsNullOrEmpty(endOfLifeDate))
            {
                 WithArguments(endOfLifeDate);
            }

            return this;
        }

        /// <summary>
        /// The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.
        /// </summary>
        public AzureSigImageVersionCreateTask ExcludeFromLatest(string excludeFromLatest = null)
        {
            WithArguments("--exclude-from-latest");
            if (!string.IsNullOrEmpty(excludeFromLatest))
            {
                 WithArguments(excludeFromLatest);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureSigImageVersionCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Default replicate count. For region specific, use --target-regions.
        /// </summary>
        public AzureSigImageVersionCreateTask ReplicaCount(string replicaCount = null)
        {
            WithArguments("--replica-count");
            if (!string.IsNullOrEmpty(replicaCount))
            {
                 WithArguments(replicaCount);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureSigImageVersionCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Space separated region list, use "<region>=<replicate count>" to apply region specific replicate count.
        /// </summary>
        public AzureSigImageVersionCreateTask TargetRegions(string targetRegions = null)
        {
            WithArguments("--target-regions");
            if (!string.IsNullOrEmpty(targetRegions))
            {
                 WithArguments(targetRegions);
            }

            return this;
        }
     }
}
