
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentSourceDeleteTask : ExternalProcessTaskBase<AzureFunctionappDeploymentSourceDeleteTask>
     {
        
        /// <summary>
        /// Delete a source control deployment configuration.
        /// </summary>
        public AzureFunctionappDeploymentSourceDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp deployment source delete");
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
