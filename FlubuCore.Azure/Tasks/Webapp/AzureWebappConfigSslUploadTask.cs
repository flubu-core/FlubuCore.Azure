
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigSslUploadTask : ExternalProcessTaskBase<AzureWebappConfigSslUploadTask>
     {
        
        /// <summary>
        /// Upload an SSL certificate to a web app.
        /// </summary>
        public AzureWebappConfigSslUploadTask(string certificateFile = null ,  string certificatePassword = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config ssl upload");
WithArguments("--certificate-file");
            if (!string.IsNullOrEmpty(certificateFile))
            {
                 WithArguments(certificateFile);
            }

WithArguments("--certificate-password");
            if (!string.IsNullOrEmpty(certificatePassword))
            {
                 WithArguments(certificatePassword);
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
