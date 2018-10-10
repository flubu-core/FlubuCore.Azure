
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationPackageCreateTask : ExternalProcessTaskBase<AzureBatchApplicationPackageCreateTask>
     {
        
        /// <summary>
        /// Create a Batch application package record and activate it.
        /// </summary>
        public AzureBatchApplicationPackageCreateTask(string applicationId = null ,  string name = null ,  string packageFile = null ,  string resourceGroup = null ,  string version = null)
        {
            WithArguments("az batch application package create");
WithArguments("--application-id");
            if (!string.IsNullOrEmpty(applicationId))
            {
                 WithArguments(applicationId);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--package-file");
            if (!string.IsNullOrEmpty(packageFile))
            {
                 WithArguments(packageFile);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

        }

        protected override string Description { get; set; }
        
     }
}
