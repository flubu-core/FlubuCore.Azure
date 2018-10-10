
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubCertificateGenerateVerificationCodeTask : ExternalProcessTaskBase<AzureIotHubCertificateGenerateVerificationCodeTask>
     {
        
        /// <summary>
        /// Generates a verification code for an Azure IoT Hub certificate.
        /// </summary>
        public AzureIotHubCertificateGenerateVerificationCodeTask(string etag = null ,  string hubName = null ,  string name = null)
        {
            WithArguments("az iot hub certificate generate-verification-code");
WithArguments("--etag");
            if (!string.IsNullOrEmpty(etag))
            {
                 WithArguments(etag);
            }

WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubCertificateGenerateVerificationCodeTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
