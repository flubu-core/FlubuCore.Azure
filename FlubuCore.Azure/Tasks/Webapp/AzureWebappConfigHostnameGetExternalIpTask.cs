
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigHostnameGetExternalIpTask : ExternalProcessTaskBase<AzureWebappConfigHostnameGetExternalIpTask>
     {
        
        /// <summary>
        /// Get the external-facing IP address for a web app.
        /// </summary>
        public AzureWebappConfigHostnameGetExternalIpTask(string resourceGroup = null ,  string webappName = null)
        {
            WithArguments("az webapp config hostname get-external-ip");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--webapp-name");
            if (!string.IsNullOrEmpty(webappName))
            {
                 WithArguments(webappName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
