
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceSendD2cMessageTask : ExternalProcessTaskBase<AzureIotDeviceSendD2cMessageTask>
     {
        
        /// <summary>
        /// Send an mqtt device-to-cloud message.
        /// </summary>
        public AzureIotDeviceSendD2cMessageTask(string deviceId = null)
        {
            WithArguments("az iot device send-d2c-message");
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
        public AzureIotDeviceSendD2cMessageTask Da(string da = null)
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
        public AzureIotDeviceSendD2cMessageTask HubName(string hubName = null)
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
        public AzureIotDeviceSendD2cMessageTask Login(string login = null)
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
        public AzureIotDeviceSendD2cMessageTask Mc(string mc = null)
        {
            WithArguments("--mc");
            if (!string.IsNullOrEmpty(mc))
            {
                 WithArguments(mc);
            }

            return this;
        }

        /// <summary>
        /// Message property bag in key-value pairs with the following format: a=b;c=d.
        /// </summary>
        public AzureIotDeviceSendD2cMessageTask Properties(string properties = null)
        {
            WithArguments("--properties");
            if (!string.IsNullOrEmpty(properties))
            {
                 WithArguments(properties);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotDeviceSendD2cMessageTask ResourceGroup(string resourceGroup = null)
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
