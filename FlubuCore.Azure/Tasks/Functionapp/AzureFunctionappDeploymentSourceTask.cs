
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentSourceTask : ExternalProcessTaskBase<AzureFunctionappDeploymentSourceTask>
     {
        
        /// <summary>
        /// Manage function app deployment via source control.
        /// </summary>
        public AzureFunctionappDeploymentSourceTask()
        {
            WithArguments("az functionapp deployment source");
        }

        protected override string Description { get; set; }
        
     }
}
