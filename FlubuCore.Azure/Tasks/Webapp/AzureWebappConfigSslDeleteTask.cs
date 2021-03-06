
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigSslDeleteTask : ExternalProcessTaskBase<AzureWebappConfigSslDeleteTask>
     {
        
        /// <summary>
        /// Delete an SSL certificate from a web app.
        /// </summary>
        public AzureWebappConfigSslDeleteTask(string certificateThumbprint = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config ssl delete");
WithArguments("--certificate-thumbprint");
            if (!string.IsNullOrEmpty(certificateThumbprint))
            {
                 WithArguments(certificateThumbprint);
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
