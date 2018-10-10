
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupDeploymentCreateTask : ExternalProcessTaskBase<AzureGroupDeploymentCreateTask>
     {
        
        /// <summary>
        /// Start a deployment.
        /// </summary>
        public AzureGroupDeploymentCreateTask(string resourceGroup = null)
        {
            WithArguments("az group deployment create");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).
        /// </summary>
        public AzureGroupDeploymentCreateTask Mode(string mode = null)
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
        public AzureGroupDeploymentCreateTask Name(string name = null)
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
        public AzureGroupDeploymentCreateTask NoWait(string noWait = null)
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
        public AzureGroupDeploymentCreateTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }

        /// <summary>
        /// The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.
        /// </summary>
        public AzureGroupDeploymentCreateTask RollbackOnError(string rollbackOnError = null)
        {
            WithArguments("--rollback-on-error");
            if (!string.IsNullOrEmpty(rollbackOnError))
            {
                 WithArguments(rollbackOnError);
            }

            return this;
        }

        /// <summary>
        /// A template file path in the file system.
        /// </summary>
        public AzureGroupDeploymentCreateTask TemplateFile(string templateFile = null)
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
        public AzureGroupDeploymentCreateTask TemplateUri(string templateUri = null)
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
