
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubMonitorFeedbackTask : ExternalProcessTaskBase<AzureIotHubMonitorFeedbackTask>
     {
        
        /// <summary>
        /// Monitor feedback sent by devices to acknowledge cloud-to-device (C2D) messages.
        /// </summary>
        public AzureIotHubMonitorFeedbackTask()
        {
            WithArguments("az iot hub monitor-feedback");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Target Device.
        /// </summary>
        public AzureIotHubMonitorFeedbackTask DeviceId(string deviceId = null)
        {
            WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

            return this;
        }

        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubMonitorFeedbackTask HubName(string hubName = null)
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
        public AzureIotHubMonitorFeedbackTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Reinstall uamqp dependency compatible with extension version. Default: false.
        /// </summary>
        public AzureIotHubMonitorFeedbackTask Repair(string repair = null)
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
        public AzureIotHubMonitorFeedbackTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Feedback monitor will block until a message with specific id (uuid) is received.
        /// </summary>
        public AzureIotHubMonitorFeedbackTask WaitOnMsg(string waitOnMsg = null)
        {
            WithArguments("--wait-on-msg");
            if (!string.IsNullOrEmpty(waitOnMsg))
            {
                 WithArguments(waitOnMsg);
            }

            return this;
        }

        /// <summary>
        /// Skip user prompts. Indicates acceptance of dependency installation (if required). Used primarily for automation scenarios. Default: false.
        /// </summary>
        public AzureIotHubMonitorFeedbackTask Yes(string yes = null)
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
