
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceC2dMessageReceiveTask : ExternalProcessTaskBase<AzureIotDeviceC2dMessageReceiveTask>
     {
        
        /// <summary>
        /// Receive a cloud-to-device message.
        /// </summary>
        public AzureIotDeviceC2dMessageReceiveTask(string deviceId = null)
        {
            WithArguments("az iot device c2d-message receive");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotDeviceC2dMessageReceiveTask HubName(string hubName = null)
        {
            WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

            return this;
        }

        /// <summary>
        /// Specifies the amount of time a message will be invisible to other receive calls.
        /// </summary>
        public AzureIotDeviceC2dMessageReceiveTask LockTimeout(string lockTimeout = null)
        {
            WithArguments("--lock-timeout");
            if (!string.IsNullOrEmpty(lockTimeout))
            {
                 WithArguments(lockTimeout);
            }

            return this;
        }

        /// <summary>
        /// This command supports an entity connection string with rights to perform action. Use to avoid session login via "az login". If both an entity connection string and name are provided the connection string takes priority.
        /// </summary>
        public AzureIotDeviceC2dMessageReceiveTask Login(string login = null)
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
        public AzureIotDeviceC2dMessageReceiveTask ResourceGroup(string resourceGroup = null)
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
