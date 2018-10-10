
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectCreateTask : ExternalProcessTaskBase<AzureDmsProjectCreateTask>
     {
        
        /// <summary>
        /// Create a migration Project which can contain multiple Tasks.
        /// </summary>
        public AzureDmsProjectCreateTask(string location = null ,  string name = null ,  string resourceGroup = null ,  string serviceName = null ,  string sourcePlatform = null ,  string targetPlatform = null)
        {
            WithArguments("az dms project create");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

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

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

WithArguments("--source-platform");
            if (!string.IsNullOrEmpty(sourcePlatform))
            {
                 WithArguments(sourcePlatform);
            }

WithArguments("--target-platform");
            if (!string.IsNullOrEmpty(targetPlatform))
            {
                 WithArguments(targetPlatform);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A space-delimited list of tags in "tag1[=value1]" format.
        /// </summary>
        public AzureDmsProjectCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
