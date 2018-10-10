
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisImportTask : ExternalProcessTaskBase<AzureRedisImportTask>
     {
        
        /// <summary>
        /// Import data into a Redis cache.
        /// </summary>
        public AzureRedisImportTask(string fileFormat = null ,  string files = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az redis import");
WithArguments("--file-format");
            if (!string.IsNullOrEmpty(fileFormat))
            {
                 WithArguments(fileFormat);
            }

WithArguments("--files");
            if (!string.IsNullOrEmpty(files))
            {
                 WithArguments(files);
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

        }

        protected override string Description { get; set; }
        
     }
}
