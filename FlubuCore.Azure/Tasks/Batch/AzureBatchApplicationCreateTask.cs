
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationCreateTask : ExternalProcessTaskBase<AzureBatchApplicationCreateTask>
     {
        
        /// <summary>
        /// Adds an application to the specified Batch account.
        /// </summary>
        public AzureBatchApplicationCreateTask(string applicationId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch application create");
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify to indicate whether packages within the application may be overwritten using the same version string. True if flag present.
        /// </summary>
        public AzureBatchApplicationCreateTask AllowUpdates(string allowUpdates = null)
        {
            WithArguments("--allow-updates");
            if (!string.IsNullOrEmpty(allowUpdates))
            {
                 WithArguments(allowUpdates);
            }

            return this;
        }

        /// <summary>
        /// The display name for the application.
        /// </summary>
        public AzureBatchApplicationCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }
     }
}
