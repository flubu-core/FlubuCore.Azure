
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshDeploymentCreateTask : ExternalProcessTaskBase<AzureMeshDeploymentCreateTask>
     {
        
        /// <summary>
        /// Create a Service Fabric Mesh application.
        /// </summary>
        public AzureMeshDeploymentCreateTask(string resourceGroup = null)
        {
            WithArguments("az mesh deployment create");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        public AzureMeshDeploymentCreateTask Mode(string mode = null)
        {
            WithArguments("--mode");
            if (!string.IsNullOrEmpty(mode))
            {
                 WithArguments(mode);
            }

            return this;
        }

        /// <summary>
        /// The deployment name. Default to template file base name.
        /// </summary>
        public AzureMeshDeploymentCreateTask Name(string name = null)
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
        public AzureMeshDeploymentCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        public AzureMeshDeploymentCreateTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }

        /// <summary>
        /// The full file path of creation template.
        /// </summary>
        public AzureMeshDeploymentCreateTask TemplateFile(string templateFile = null)
        {
            WithArguments("--template-file");
            if (!string.IsNullOrEmpty(templateFile))
            {
                 WithArguments(templateFile);
            }

            return this;
        }

        /// <summary>
        /// The full file path of creation template on a http or https link.
        /// </summary>
        public AzureMeshDeploymentCreateTask TemplateUri(string templateUri = null)
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
