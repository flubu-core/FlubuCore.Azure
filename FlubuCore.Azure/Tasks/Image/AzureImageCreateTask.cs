
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Image
{
     public partial class AzureImageCreateTask : ExternalProcessTaskBase<AzureImageCreateTask>
     {
        
        /// <summary>
        /// Create a custom Virtual Machine Image from managed disks or snapshots.
        /// </summary>
        public AzureImageCreateTask(string name = null ,  string resourceGroup = null ,  string source = null)
        {
            WithArguments("az image create");
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

WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.
        /// </summary>
        public AzureImageCreateTask DataDiskSources(string dataDiskSources = null)
        {
            WithArguments("--data-disk-sources");
            if (!string.IsNullOrEmpty(dataDiskSources))
            {
                 WithArguments(dataDiskSources);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureImageCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        public AzureImageCreateTask OsType(string osType = null)
        {
            WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureImageCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.
        /// </summary>
        public AzureImageCreateTask ZoneResilient(string zoneResilient = null)
        {
            WithArguments("--zone-resilient");
            if (!string.IsNullOrEmpty(zoneResilient))
            {
                 WithArguments(zoneResilient);
            }

            return this;
        }
     }
}
