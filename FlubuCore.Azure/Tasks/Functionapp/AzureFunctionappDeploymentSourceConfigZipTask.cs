
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentSourceConfigZipTask : ExternalProcessTaskBase<AzureFunctionappDeploymentSourceConfigZipTask>
     {
        
        /// <summary>
        /// Perform deployment using the kudu zip push deployment for a function app.
        /// </summary>
        public AzureFunctionappDeploymentSourceConfigZipTask(string name = null ,  string resourceGroup = null ,  string src = null)
        {
            WithArguments("az functionapp deployment source config-zip");
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

WithArguments("--src");
            if (!string.IsNullOrEmpty(src))
            {
                 WithArguments(src);
            }

        }

        protected override string Description { get; set; }
        
     }
}
