
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageDefinitionCreateTask : ExternalProcessTaskBase<AzureSigImageDefinitionCreateTask>
     {
        
        /// <summary>
        /// Create a gallery image definition.
        /// </summary>
        public AzureSigImageDefinitionCreateTask(string galleryImageDefinition = null ,  string galleryName = null ,  string offer = null ,  string osType = null ,  string publisher = null ,  string resourceGroup = null ,  string sku = null)
        {
            WithArguments("az sig image-definition create");
WithArguments("--gallery-image-definition");
            if (!string.IsNullOrEmpty(galleryImageDefinition))
            {
                 WithArguments(galleryImageDefinition);
            }

WithArguments("--gallery-name");
            if (!string.IsNullOrEmpty(galleryName))
            {
                 WithArguments(galleryName);
            }

WithArguments("--offer");
            if (!string.IsNullOrEmpty(offer))
            {
                 WithArguments(offer);
            }

WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

WithArguments("--publisher");
            if (!string.IsNullOrEmpty(publisher))
            {
                 WithArguments(publisher);
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
        /// Disk types which would not work with the image, e.g., Standard_LRS.
        /// </summary>
        public AzureSigImageDefinitionCreateTask DisallowedDiskTypes(string disallowedDiskTypes = null)
        {
            WithArguments("--disallowed-disk-types");
            if (!string.IsNullOrEmpty(disallowedDiskTypes))
            {
                 WithArguments(disallowedDiskTypes);
            }

            return this;
        }

        /// <summary>
        /// The end of life date, e.g. '2020-12-31'.
        /// </summary>
        public AzureSigImageDefinitionCreateTask EndOfLifeDate(string endOfLifeDate = null)
        {
            WithArguments("--end-of-life-date");
            if (!string.IsNullOrEmpty(endOfLifeDate))
            {
                 WithArguments(endOfLifeDate);
            }

            return this;
        }

        /// <summary>
        /// The Eula agreement for the gallery image.
        /// </summary>
        public AzureSigImageDefinitionCreateTask Eula(string eula = null)
        {
            WithArguments("--eula");
            if (!string.IsNullOrEmpty(eula))
            {
                 WithArguments(eula);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureSigImageDefinitionCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The privacy statement uri.
        /// </summary>
        public AzureSigImageDefinitionCreateTask PrivacyStatementUri(string privacyStatementUri = null)
        {
            WithArguments("--privacy-statement-uri");
            if (!string.IsNullOrEmpty(privacyStatementUri))
            {
                 WithArguments(privacyStatementUri);
            }

            return this;
        }

        /// <summary>
        /// The release note uri.
        /// </summary>
        public AzureSigImageDefinitionCreateTask ReleaseNoteUri(string releaseNoteUri = null)
        {
            WithArguments("--release-note-uri");
            if (!string.IsNullOrEmpty(releaseNoteUri))
            {
                 WithArguments(releaseNoteUri);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureSigImageDefinitionCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Plan name.
        /// </summary>
        public AzureSigImageDefinitionCreateTask PlanName(string planName = null)
        {
            WithArguments("--plan-name");
            if (!string.IsNullOrEmpty(planName))
            {
                 WithArguments(planName);
            }

            return this;
        }

        /// <summary>
        /// Plan product.
        /// </summary>
        public AzureSigImageDefinitionCreateTask PlanProduct(string planProduct = null)
        {
            WithArguments("--plan-product");
            if (!string.IsNullOrEmpty(planProduct))
            {
                 WithArguments(planProduct);
            }

            return this;
        }

        /// <summary>
        /// Plan publisher.
        /// </summary>
        public AzureSigImageDefinitionCreateTask PlanPublisher(string planPublisher = null)
        {
            WithArguments("--plan-publisher");
            if (!string.IsNullOrEmpty(planPublisher))
            {
                 WithArguments(planPublisher);
            }

            return this;
        }

        /// <summary>
        /// Maximum cpu cores.
        /// </summary>
        public AzureSigImageDefinitionCreateTask MaximumCpuCore(string maximumCpuCore = null)
        {
            WithArguments("--maximum-cpu-core");
            if (!string.IsNullOrEmpty(maximumCpuCore))
            {
                 WithArguments(maximumCpuCore);
            }

            return this;
        }

        /// <summary>
        /// Maximum memory in MB.
        /// </summary>
        public AzureSigImageDefinitionCreateTask MaximumMemory(string maximumMemory = null)
        {
            WithArguments("--maximum-memory");
            if (!string.IsNullOrEmpty(maximumMemory))
            {
                 WithArguments(maximumMemory);
            }

            return this;
        }

        /// <summary>
        /// Minimum cpu cores.
        /// </summary>
        public AzureSigImageDefinitionCreateTask MinimumCpuCore(string minimumCpuCore = null)
        {
            WithArguments("--minimum-cpu-core");
            if (!string.IsNullOrEmpty(minimumCpuCore))
            {
                 WithArguments(minimumCpuCore);
            }

            return this;
        }

        /// <summary>
        /// Minimum memory in MB.
        /// </summary>
        public AzureSigImageDefinitionCreateTask MinimumMemory(string minimumMemory = null)
        {
            WithArguments("--minimum-memory");
            if (!string.IsNullOrEmpty(minimumMemory))
            {
                 WithArguments(minimumMemory);
            }

            return this;
        }
     }
}
