
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubMonitorEventsTask : ExternalProcessTaskBase<AzureIotHubMonitorEventsTask>
     {
        
        /// <summary>
        /// Monitor device telemetry & messages sent to an IoT Hub.
        /// </summary>
        public AzureIotHubMonitorEventsTask()
        {
            WithArguments("az iot hub monitor-events");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify the consumer group to use when connecting to event hub endpoint.
        /// </summary>
        public AzureIotHubMonitorEventsTask Cg(string cg = null)
        {
            WithArguments("--cg");
            if (!string.IsNullOrEmpty(cg))
            {
                 WithArguments(cg);
            }

            return this;
        }

        /// <summary>
        /// Target Device.
        /// </summary>
        public AzureIotHubMonitorEventsTask DeviceId(string deviceId = null)
        {
            WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

            return this;
        }

        /// <summary>
        /// Indicates the time that should be used as a starting point to read messages from the partitions. Units are milliseconds since unix epoch. If no time is indicated "now" is used.
        /// </summary>
        public AzureIotHubMonitorEventsTask EnqueuedTime(string enqueuedTime = null)
        {
            WithArguments("--enqueued-time");
            if (!string.IsNullOrEmpty(enqueuedTime))
            {
                 WithArguments(enqueuedTime);
            }

            return this;
        }

        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubMonitorEventsTask HubName(string hubName = null)
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
        public AzureIotHubMonitorEventsTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Indicate key message properties to output. sys = system properties, app = application properties, anno = annotations.
        /// </summary>
        public AzureIotHubMonitorEventsTask Properties(string properties = null)
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
        public AzureIotHubMonitorEventsTask Repair(string repair = null)
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
        public AzureIotHubMonitorEventsTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Maximum seconds to maintain connection without receiving message. Use 0 for infinity.
        /// </summary>
        public AzureIotHubMonitorEventsTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Skip user prompts. Indicates acceptance of dependency installation (if required). Used primarily for automation scenarios. Default: false.
        /// </summary>
        public AzureIotHubMonitorEventsTask Yes(string yes = null)
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
