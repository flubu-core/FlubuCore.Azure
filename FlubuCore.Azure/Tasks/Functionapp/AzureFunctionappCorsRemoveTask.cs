
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappCorsRemoveTask : ExternalProcessTaskBase<AzureFunctionappCorsRemoveTask>
     {
        
        /// <summary>
        /// Remove allowed origins.
        /// </summary>
        public AzureFunctionappCorsRemoveTask(string allowedOrigins = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp cors remove");
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
