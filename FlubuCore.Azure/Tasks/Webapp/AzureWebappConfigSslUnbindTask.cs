
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigSslUnbindTask : ExternalProcessTaskBase<AzureWebappConfigSslUnbindTask>
     {
        
        /// <summary>
        /// Unbind an SSL certificate from a web app.
        /// </summary>
        public AzureWebappConfigSslUnbindTask(string certificateThumbprint = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config ssl unbind");
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
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigSslUnbindTask Slot(string slot = null)
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
