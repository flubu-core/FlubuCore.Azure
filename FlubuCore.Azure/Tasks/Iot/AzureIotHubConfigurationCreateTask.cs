
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubConfigurationCreateTask : ExternalProcessTaskBase<AzureIotHubConfigurationCreateTask>
     {
        
        /// <summary>
        /// Create an IoT device configuration in the target IoT Hub.
        /// </summary>
        public AzureIotHubConfigurationCreateTask(string configId = null ,  string content = null)
        {
            WithArguments("az iot hub configuration create");
WithArguments("--config-id");
            if (!string.IsNullOrEmpty(configId))
            {
                 WithArguments(configId);
            }

WithArguments("--content");
            if (!string.IsNullOrEmpty(content))
            {
                 WithArguments(content);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubConfigurationCreateTask HubName(string hubName = null)
        {
            WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

            return this;
        }

        /// <summary>
        /// Map of labels to be applied to target configuration. Format example: {"key0":"value0", "key1":"value1"}.
        /// </summary>
        public AzureIotHubConfigurationCreateTask Lab(string lab = null)
        {
            WithArguments("--lab");
            if (!string.IsNullOrEmpty(lab))
            {
                 WithArguments(lab);
            }

            return this;
        }

        /// <summary>
        /// This command supports an entity connection string with rights to perform action. Use to avoid session login via "az login". If both an entity connection string and name are provided the connection string takes priority.
        /// </summary>
        public AzureIotHubConfigurationCreateTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Device configuration metric definitions. Provide file path or raw json.
        /// </summary>
        public AzureIotHubConfigurationCreateTask Metrics(string metrics = null)
        {
            WithArguments("--metrics");
            if (!string.IsNullOrEmpty(metrics))
            {
                 WithArguments(metrics);
            }

            return this;
        }

        /// <summary>
        /// Weight of the device configuration in case of competing rules (highest wins).
        /// </summary>
        public AzureIotHubConfigurationCreateTask Pri(string pri = null)
        {
            WithArguments("--pri");
            if (!string.IsNullOrEmpty(pri))
            {
                 WithArguments(pri);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubConfigurationCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Target condition in which a device configuration applies to.
        /// </summary>
        public AzureIotHubConfigurationCreateTask TargetCondition(string targetCondition = null)
        {
            WithArguments("--target-condition");
            if (!string.IsNullOrEmpty(targetCondition))
            {
                 WithArguments(targetCondition);
            }

            return this;
        }
     }
}
