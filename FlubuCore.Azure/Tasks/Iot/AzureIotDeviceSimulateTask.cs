
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceSimulateTask : ExternalProcessTaskBase<AzureIotDeviceSimulateTask>
     {
        
        /// <summary>
        /// Simulate a device in an Azure IoT Hub.
        /// </summary>
        public AzureIotDeviceSimulateTask(string deviceId = null)
        {
            WithArguments("az iot device simulate");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Message body.
        /// </summary>
        public AzureIotDeviceSimulateTask Da(string da = null)
        {
            WithArguments("--da");
            if (!string.IsNullOrEmpty(da))
            {
                 WithArguments(da);
            }

            return this;
        }

        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotDeviceSimulateTask HubName(string hubName = null)
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
        public AzureIotDeviceSimulateTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Number of device messages to send to IoT Hub.
        /// </summary>
        public AzureIotDeviceSimulateTask Mc(string mc = null)
        {
            WithArguments("--mc");
            if (!string.IsNullOrEmpty(mc))
            {
                 WithArguments(mc);
            }

            return this;
        }

        /// <summary>
        /// Delay in seconds between device-to-cloud messages.
        /// </summary>
        public AzureIotDeviceSimulateTask Mi(string mi = null)
        {
            WithArguments("--mi");
            if (!string.IsNullOrEmpty(mi))
            {
                 WithArguments(mi);
            }

            return this;
        }

        /// <summary>
        /// Indicates device-to-cloud message protocol.
        /// </summary>
        public AzureIotDeviceSimulateTask Proto(string proto = null)
        {
            WithArguments("--proto");
            if (!string.IsNullOrEmpty(proto))
            {
                 WithArguments(proto);
            }

            return this;
        }

        /// <summary>
        /// Indicates how to settle received cloud-to-device messages. Supported with HTTP only.
        /// </summary>
        public AzureIotDeviceSimulateTask ReceiveSettle(string receiveSettle = null)
        {
            WithArguments("--receive-settle");
            if (!string.IsNullOrEmpty(receiveSettle))
            {
                 WithArguments(receiveSettle);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotDeviceSimulateTask ResourceGroup(string resourceGroup = null)
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
