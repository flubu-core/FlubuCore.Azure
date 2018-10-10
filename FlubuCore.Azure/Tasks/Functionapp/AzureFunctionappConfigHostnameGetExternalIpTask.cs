
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigHostnameGetExternalIpTask : ExternalProcessTaskBase<AzureFunctionappConfigHostnameGetExternalIpTask>
     {
        
        /// <summary>
        /// Get the external-facing IP address for a function app.
        /// </summary>
        public AzureFunctionappConfigHostnameGetExternalIpTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config hostname get-external-ip");
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
