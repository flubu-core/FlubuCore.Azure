
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationPackageActivateTask : ExternalProcessTaskBase<AzureBatchApplicationPackageActivateTask>
     {
        
        /// <summary>
        /// Activates a Batch application package.
        /// </summary>
        public AzureBatchApplicationPackageActivateTask(string applicationId = null ,  string format = null ,  string name = null ,  string resourceGroup = null ,  string version = null)
        {
            WithArguments("az batch application package activate");
WithArguments("--application-id");
            if (!string.IsNullOrEmpty(applicationId))
            {
                 WithArguments(applicationId);
            }

WithArguments("--format");
            if (!string.IsNullOrEmpty(format))
            {
                 WithArguments(format);
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

WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

        }

        protected override string Description { get; set; }
        
     }
}
