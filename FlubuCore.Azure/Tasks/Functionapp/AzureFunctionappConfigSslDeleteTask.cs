
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigSslDeleteTask : ExternalProcessTaskBase<AzureFunctionappConfigSslDeleteTask>
     {
        
        /// <summary>
        /// Delete an SSL certificate from a function app.
        /// </summary>
        public AzureFunctionappConfigSslDeleteTask(string certificateThumbprint = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config ssl delete");
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
