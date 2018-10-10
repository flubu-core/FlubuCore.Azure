
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappCorsAddTask : ExternalProcessTaskBase<AzureFunctionappCorsAddTask>
     {
        
        /// <summary>
        /// Add allowed origins.
        /// </summary>
        public AzureFunctionappCorsAddTask(string allowedOrigins = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp cors add");
WithArguments("--allowed-origins");
            if (!string.IsNullOrEmpty(allowedOrigins))
            {
                 WithArguments(allowedOrigins);
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
        
     }
}
