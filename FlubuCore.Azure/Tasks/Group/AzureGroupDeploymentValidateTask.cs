
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupDeploymentValidateTask : ExternalProcessTaskBase<AzureGroupDeploymentValidateTask>
     {
        
        /// <summary>
        /// Validate whether a template is syntactically correct.
        /// </summary>
        public AzureGroupDeploymentValidateTask(string resourceGroup = null)
        {
            WithArguments("az group deployment validate");
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
        public AzureGroupDeploymentValidateTask Mode(string mode = null)
        {
            WithArguments("--mode");
            if (!string.IsNullOrEmpty(mode))
            {
                 WithArguments(mode);
            }

            return this;
        }

        /// <summary>
        /// Supply deployment parameter values.
        /// </summary>
        public AzureGroupDeploymentValidateTask Parameters(string parameters = null)
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
        public AzureGroupDeploymentValidateTask RollbackOnError(string rollbackOnError = null)
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
        public AzureGroupDeploymentValidateTask TemplateFile(string templateFile = null)
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
        public AzureGroupDeploymentValidateTask TemplateUri(string templateUri = null)
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
