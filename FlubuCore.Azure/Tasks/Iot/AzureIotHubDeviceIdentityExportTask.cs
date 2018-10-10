
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubDeviceIdentityExportTask : ExternalProcessTaskBase<AzureIotHubDeviceIdentityExportTask>
     {
        
        /// <summary>
        /// Export all device identities from an IoT Hub to an Azure Storage blob container.
        /// </summary>
        public AzureIotHubDeviceIdentityExportTask(string bcu = null ,  string hubName = null)
        {
            WithArguments("az iot hub device-identity export");
WithArguments("--bcu");
            if (!string.IsNullOrEmpty(bcu))
            {
                 WithArguments(bcu);
            }

WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If set, keys are exported normally. Otherwise, keys are set to null in export output.
        /// </summary>
        public AzureIotHubDeviceIdentityExportTask Ik(string ik = null)
        {
            WithArguments("--ik");
            if (!string.IsNullOrEmpty(ik))
            {
                 WithArguments(ik);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubDeviceIdentityExportTask ResourceGroup(string resourceGroup = null)
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
