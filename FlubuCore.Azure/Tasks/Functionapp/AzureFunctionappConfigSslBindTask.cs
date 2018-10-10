
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigSslBindTask : ExternalProcessTaskBase<AzureFunctionappConfigSslBindTask>
     {
        
        /// <summary>
        /// Bind an SSL certificate to a function app.
        /// </summary>
        public AzureFunctionappConfigSslBindTask(string certificateThumbprint = null ,  string name = null ,  string resourceGroup = null ,  string sslType = null)
        {
            WithArguments("az functionapp config ssl bind");
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

WithArguments("--ssl-type");
            if (!string.IsNullOrEmpty(sslType))
            {
                 WithArguments(sslType);
            }

        }

        protected override string Description { get; set; }
        
     }
}
