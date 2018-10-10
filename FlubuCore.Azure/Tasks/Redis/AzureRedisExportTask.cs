
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisExportTask : ExternalProcessTaskBase<AzureRedisExportTask>
     {
        
        /// <summary>
        /// Export data stored in a Redis cache.
        /// </summary>
        public AzureRedisExportTask(string container = null ,  string name = null ,  string prefix = null ,  string resourceGroup = null)
        {
            WithArguments("az redis export");
WithArguments("--container");
            if (!string.IsNullOrEmpty(container))
            {
                 WithArguments(container);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--prefix");
            if (!string.IsNullOrEmpty(prefix))
            {
                 WithArguments(prefix);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// File format to export.
        /// </summary>
        public AzureRedisExportTask FileFormat(string fileFormat = null)
        {
            WithArguments("--file-format");
            if (!string.IsNullOrEmpty(fileFormat))
            {
                 WithArguments(fileFormat);
            }

            return this;
        }
     }
}
