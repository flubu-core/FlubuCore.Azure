
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeleteTask : ExternalProcessTaskBase<AzureFunctionappDeleteTask>
     {
        
        /// <summary>
        /// Delete a function app.
        /// </summary>
        public AzureFunctionappDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp delete");
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
