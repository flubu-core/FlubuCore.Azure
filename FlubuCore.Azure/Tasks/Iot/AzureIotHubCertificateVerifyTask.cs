
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubCertificateVerifyTask : ExternalProcessTaskBase<AzureIotHubCertificateVerifyTask>
     {
        
        /// <summary>
        /// Verifies an Azure IoT Hub certificate.
        /// </summary>
        public AzureIotHubCertificateVerifyTask(string etag = null ,  string hubName = null ,  string name = null ,  string path = null)
        {
            WithArguments("az iot hub certificate verify");
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

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubCertificateVerifyTask ResourceGroup(string resourceGroup = null)
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
