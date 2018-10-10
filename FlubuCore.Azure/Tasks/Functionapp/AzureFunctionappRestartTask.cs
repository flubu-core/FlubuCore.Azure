
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappRestartTask : ExternalProcessTaskBase<AzureFunctionappRestartTask>
     {
        
        /// <summary>
        /// Restart a function app.
        /// </summary>
        public AzureFunctionappRestartTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp restart");
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
