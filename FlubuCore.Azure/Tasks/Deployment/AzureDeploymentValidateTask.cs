
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Deployment
{
     public partial class AzureDeploymentValidateTask : ExternalProcessTaskBase<AzureDeploymentValidateTask>
     {
        
        /// <summary>
        /// Validate whether a template is syntactically correct.
        /// </summary>
        public AzureDeploymentValidateTask(string location = null)
        {
            WithArguments("az deployment validate");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Supply deployment parameter values.
        /// </summary>
        public AzureDeploymentValidateTask Parameters(string parameters = null)
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
        public AzureDeploymentValidateTask TemplateFile(string templateFile = null)
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
        public AzureDeploymentValidateTask TemplateUri(string templateUri = null)
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
