
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigSslUnbindTask : ExternalProcessTaskBase<AzureFunctionappConfigSslUnbindTask>
     {
        
        /// <summary>
        /// Unbind an SSL certificate from a function app.
        /// </summary>
        public AzureFunctionappConfigSslUnbindTask(string certificateThumbprint = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config ssl unbind");
WithArguments("--certificate-thumbprint");
            if (!string.IsNullOrEmpty(certificateThumbprint))
            {
                 WithArguments(certificateThumbprint);
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
