
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationSetTask : ExternalProcessTaskBase<AzureBatchApplicationSetTask>
     {
        
        /// <summary>
        /// Update properties for a Batch application.
        /// </summary>
        public AzureBatchApplicationSetTask(string applicationId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch application set");
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
        /// Specify to indicate whether packages within the application may be overwritten using the same version string. Specify either 'true' or 'false' to update the property.
        /// </summary>
        public AzureBatchApplicationSetTask AllowUpdates(string allowUpdates = null)
        {
            WithArguments("--allow-updates");
            if (!string.IsNullOrEmpty(allowUpdates))
            {
                 WithArguments(allowUpdates);
            }

            return this;
        }

        /// <summary>
        /// The package to use if a client requests the application but does not specify a version.
        /// </summary>
        public AzureBatchApplicationSetTask DefaultVersion(string defaultVersion = null)
        {
            WithArguments("--default-version");
            if (!string.IsNullOrEmpty(defaultVersion))
            {
                 WithArguments(defaultVersion);
            }

            return this;
        }

        /// <summary>
        /// The display name for the application.
        /// </summary>
        public AzureBatchApplicationSetTask DisplayName(string displayName = null)
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
