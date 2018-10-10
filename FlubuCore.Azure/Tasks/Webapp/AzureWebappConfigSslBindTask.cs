
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigSslBindTask : ExternalProcessTaskBase<AzureWebappConfigSslBindTask>
     {
        
        /// <summary>
        /// Bind an SSL certificate to a web app.
        /// </summary>
        public AzureWebappConfigSslBindTask(string certificateThumbprint = null ,  string name = null ,  string resourceGroup = null ,  string sslType = null)
        {
            WithArguments("az webapp config ssl bind");
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
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigSslBindTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
