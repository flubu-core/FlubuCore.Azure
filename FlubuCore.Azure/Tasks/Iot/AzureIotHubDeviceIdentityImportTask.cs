
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubDeviceIdentityImportTask : ExternalProcessTaskBase<AzureIotHubDeviceIdentityImportTask>
     {
        
        /// <summary>
        /// Import device identities to an IoT Hub from a blob.
        /// </summary>
        public AzureIotHubDeviceIdentityImportTask(string hubName = null ,  string ibcu = null ,  string obcu = null)
        {
            WithArguments("az iot hub device-identity import");
WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

WithArguments("--ibcu");
            if (!string.IsNullOrEmpty(ibcu))
            {
                 WithArguments(ibcu);
            }

WithArguments("--obcu");
            if (!string.IsNullOrEmpty(obcu))
            {
                 WithArguments(obcu);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubDeviceIdentityImportTask ResourceGroup(string resourceGroup = null)
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
