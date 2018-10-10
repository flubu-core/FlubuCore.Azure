
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupDeploymentExportTask : ExternalProcessTaskBase<AzureGroupDeploymentExportTask>
     {
        
        /// <summary>
        /// Export the template used for a deployment.
        /// </summary>
        public AzureGroupDeploymentExportTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az group deployment export");
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
        
     }
}
