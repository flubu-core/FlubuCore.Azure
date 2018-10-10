
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappLogConfigTask : ExternalProcessTaskBase<AzureWebappLogConfigTask>
     {
        
        /// <summary>
        /// Configure logging for a web app.
        /// </summary>
        public AzureWebappLogConfigTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp log config");
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
        /// Configure application logging to file system.
        /// </summary>
        public AzureWebappLogConfigTask ApplicationLogging(string applicationLogging = null)
        {
            WithArguments("--application-logging");
            if (!string.IsNullOrEmpty(applicationLogging))
            {
                 WithArguments(applicationLogging);
            }

            return this;
        }

        /// <summary>
        /// Configure detailed error messages.
        /// </summary>
        public AzureWebappLogConfigTask DetailedErrorMessages(string detailedErrorMessages = null)
        {
            WithArguments("--detailed-error-messages");
            if (!string.IsNullOrEmpty(detailedErrorMessages))
            {
                 WithArguments(detailedErrorMessages);
            }

            return this;
        }

        /// <summary>
        /// Configure gathering STDOUT and STDERR output from container.
        /// </summary>
        public AzureWebappLogConfigTask DockerContainerLogging(string dockerContainerLogging = null)
        {
            WithArguments("--docker-container-logging");
            if (!string.IsNullOrEmpty(dockerContainerLogging))
            {
                 WithArguments(dockerContainerLogging);
            }

            return this;
        }

        /// <summary>
        /// Configure failed request tracing.
        /// </summary>
        public AzureWebappLogConfigTask FailedRequestTracing(string failedRequestTracing = null)
        {
            WithArguments("--failed-request-tracing");
            if (!string.IsNullOrEmpty(failedRequestTracing))
            {
                 WithArguments(failedRequestTracing);
            }

            return this;
        }

        /// <summary>
        /// Logging level.
        /// </summary>
        public AzureWebappLogConfigTask Level(string level = null)
        {
            WithArguments("--level");
            if (!string.IsNullOrEmpty(level))
            {
                 WithArguments(level);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappLogConfigTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Configure Web server logging.
        /// </summary>
        public AzureWebappLogConfigTask WebServerLogging(string webServerLogging = null)
        {
            WithArguments("--web-server-logging");
            if (!string.IsNullOrEmpty(webServerLogging))
            {
                 WithArguments(webServerLogging);
            }

            return this;
        }
     }
}
