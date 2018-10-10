
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceC2dMessageSendTask : ExternalProcessTaskBase<AzureIotDeviceC2dMessageSendTask>
     {
        
        /// <summary>
        /// Send a cloud-to-device message.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask(string deviceId = null)
        {
            WithArguments("az iot device c2d-message send");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Request the delivery of per-message feedback regarding the final state of that message. The description of ack values is as follows. Positive: If the c2d message reaches the Completed state, IoT Hub generates a feedback message. Negative: If the c2d message reaches the Dead lettered state, IoT Hub generates a feedback message. Full: IoT Hub generates a feedback message in either case. By default, no ack is requested.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Ack(string ack = null)
        {
            WithArguments("--ack");
            if (!string.IsNullOrEmpty(ack))
            {
                 WithArguments(ack);
            }

            return this;
        }

        /// <summary>
        /// Correlation Id associated with message.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Cid(string cid = null)
        {
            WithArguments("--cid");
            if (!string.IsNullOrEmpty(cid))
            {
                 WithArguments(cid);
            }

            return this;
        }

        /// <summary>
        /// Message body.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Da(string da = null)
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
        public AzureIotDeviceC2dMessageSendTask HubName(string hubName = null)
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
        public AzureIotDeviceC2dMessageSendTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Message property bag in key-value pairs with the following format: a=b;c=d.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Properties(string properties = null)
        {
            WithArguments("--properties");
            if (!string.IsNullOrEmpty(properties))
            {
                 WithArguments(properties);
            }

            return this;
        }

        /// <summary>
        /// Reinstall uamqp dependency compatible with extension version. Default: false.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Repair(string repair = null)
        {
            WithArguments("--repair");
            if (!string.IsNullOrEmpty(repair))
            {
                 WithArguments(repair);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// If set the c2d send operation will block until device feedback has been received.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Wait(string wait = null)
        {
            WithArguments("--wait");
            if (!string.IsNullOrEmpty(wait))
            {
                 WithArguments(wait);
            }

            return this;
        }

        /// <summary>
        /// Skip user prompts. Indicates acceptance of dependency installation (if required). Used primarily for automation scenarios. Default: false.
        /// </summary>
        public AzureIotDeviceC2dMessageSendTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
