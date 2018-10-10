
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsCertificateCreateTask : ExternalProcessTaskBase<AzureIotDpsCertificateCreateTask>
     {
        
        /// <summary>
        /// Create/upload an Azure IoT Hub Device Provisioning Service certificate.
        /// </summary>
        public AzureIotDpsCertificateCreateTask(string certificateName = null ,  string dpsName = null ,  string path = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps certificate create");
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
