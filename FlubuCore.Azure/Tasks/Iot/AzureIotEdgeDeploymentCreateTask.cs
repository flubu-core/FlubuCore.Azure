
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotEdgeDeploymentCreateTask : ExternalProcessTaskBase<AzureIotEdgeDeploymentCreateTask>
     {
        
        /// <summary>
        /// Create an IoT Edge deployment in the target IoT Hub.
        /// </summary>
        public AzureIotEdgeDeploymentCreateTask(string configId = null ,  string content = null)
        {
            WithArguments("az iot edge deployment create");
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
        public AzureIotEdgeDeploymentCreateTask HubName(string hubName = null)
        {
            WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

            return this;
        }

        /// <summary>
        /// Map of labels to be applied to target deployment. Use the following format: '{"key0":"value0", "key1":"value1"}'.
        /// </summary>
        public AzureIotEdgeDeploymentCreateTask Lab(string lab = null)
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
        public AzureIotEdgeDeploymentCreateTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Weight of deployment in case of competing rules (highest wins).
        /// </summary>
        public AzureIotEdgeDeploymentCreateTask Pri(string pri = null)
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
        public AzureIotEdgeDeploymentCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Target condition in which an Edge deployment applies to.
        /// </summary>
        public AzureIotEdgeDeploymentCreateTask TargetCondition(string targetCondition = null)
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
