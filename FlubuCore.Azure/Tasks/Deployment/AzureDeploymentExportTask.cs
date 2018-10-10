
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Deployment
{
     public partial class AzureDeploymentExportTask : ExternalProcessTaskBase<AzureDeploymentExportTask>
     {
        
        /// <summary>
        /// Export the template used for a deployment.
        /// </summary>
        public AzureDeploymentExportTask(string name = null)
        {
            WithArguments("az deployment export");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
