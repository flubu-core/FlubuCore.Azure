
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabEnvironmentCreateTask : ExternalProcessTaskBase<AzureLabEnvironmentCreateTask>
     {
        
        /// <summary>
        /// Create an environment in a lab.
        /// </summary>
        public AzureLabEnvironmentCreateTask(string armTemplate = null ,  string labName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab environment create");
WithArguments("--arm-template");
            if (!string.IsNullOrEmpty(armTemplate))
            {
                 WithArguments(armTemplate);
            }

WithArguments("--lab-name");
            if (!string.IsNullOrEmpty(labName))
            {
                 WithArguments(labName);
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
        /// Name of the artifact source in the lab.
        /// </summary>
        public AzureLabEnvironmentCreateTask ArtifactSourceName(string artifactSourceName = null)
        {
            WithArguments("--artifact-source-name");
            if (!string.IsNullOrEmpty(artifactSourceName))
            {
                 WithArguments(artifactSourceName);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded list of parameters. Use '@{file}' to load from a file.
        /// </summary>
        public AzureLabEnvironmentCreateTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }

        /// <summary>
        /// The tags for the resource.
        /// </summary>
        public AzureLabEnvironmentCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
