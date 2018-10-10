
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubDeviceTwinReplaceTask : ExternalProcessTaskBase<AzureIotHubDeviceTwinReplaceTask>
     {
        
        /// <summary>
        /// Replace device twin definition with target json.
        /// </summary>
        public AzureIotHubDeviceTwinReplaceTask(string deviceId = null ,  string json = null)
        {
            WithArguments("az iot hub device-twin replace");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

WithArguments("--json");
            if (!string.IsNullOrEmpty(json))
            {
                 WithArguments(json);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubDeviceTwinReplaceTask HubName(string hubName = null)
        {
            WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

            return this;
        }

        /// <summary>
        /// This command supports an entity connection string with rights to perform action. Use to avoid session login via "az login". If both an entity connection string and name are provided the connection string takes priority.
        /// </summary>
        public AzureIotHubDeviceTwinReplaceTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubDeviceTwinReplaceTask ResourceGroup(string resourceGroup = null)
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
