
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsCertificateVerifyTask : ExternalProcessTaskBase<AzureIotDpsCertificateVerifyTask>
     {
        
        /// <summary>
        /// Verify an Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        public AzureIotDpsCertificateVerifyTask(string certificateName = null ,  string dpsName = null ,  string etag = null ,  string path = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps certificate verify");
WithArguments("--certificate-name");
            if (!string.IsNullOrEmpty(certificateName))
            {
                 WithArguments(certificateName);
            }

WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--etag");
            if (!string.IsNullOrEmpty(etag))
            {
                 WithArguments(etag);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
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
