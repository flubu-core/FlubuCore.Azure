
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Deployment
{
     public partial class AzureDeploymentCreateTask : ExternalProcessTaskBase<AzureDeploymentCreateTask>
     {
        
        /// <summary>
        /// Start a deployment.
        /// </summary>
        public AzureDeploymentCreateTask(string location = null)
        {
            WithArguments("az deployment create");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The deployment name. Default to template file base name.
        /// </summary>
        public AzureDeploymentCreateTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureDeploymentCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Supply deployment parameter values.
        /// </summary>
        public AzureDeploymentCreateTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }

        /// <summary>
        /// A template file path in the file system.
        /// </summary>
        public AzureDeploymentCreateTask TemplateFile(string templateFile = null)
        {
            WithArguments("--template-file");
            if (!string.IsNullOrEmpty(templateFile))
            {
                 WithArguments(templateFile);
            }

            return this;
        }

        /// <summary>
        /// A uri to a remote template file.
        /// </summary>
        public AzureDeploymentCreateTask TemplateUri(string templateUri = null)
        {
            WithArguments("--template-uri");
            if (!string.IsNullOrEmpty(templateUri))
            {
                 WithArguments(templateUri);
            }

            return this;
        }
     }
}
