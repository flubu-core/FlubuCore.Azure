
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubInvokeDeviceMethodTask : ExternalProcessTaskBase<AzureIotHubInvokeDeviceMethodTask>
     {
        
        /// <summary>
        /// Invoke a device method.
        /// </summary>
        public AzureIotHubInvokeDeviceMethodTask(string deviceId = null ,  string methodName = null)
        {
            WithArguments("az iot hub invoke-device-method");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

WithArguments("--method-name");
            if (!string.IsNullOrEmpty(methodName))
            {
                 WithArguments(methodName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubInvokeDeviceMethodTask HubName(string hubName = null)
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
        public AzureIotHubInvokeDeviceMethodTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Json payload to be passed to method. Must be file path or raw json.
        /// </summary>
        public AzureIotHubInvokeDeviceMethodTask MethodPayload(string methodPayload = null)
        {
            WithArguments("--method-payload");
            if (!string.IsNullOrEmpty(methodPayload))
            {
                 WithArguments(methodPayload);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubInvokeDeviceMethodTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of seconds to wait for method result.
        /// </summary>
        public AzureIotHubInvokeDeviceMethodTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }
     }
}
