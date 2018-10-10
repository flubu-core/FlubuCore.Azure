
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubModuleIdentityDeleteTask : ExternalProcessTaskBase<AzureIotHubModuleIdentityDeleteTask>
     {
        
        /// <summary>
        /// Delete a device in an IoT Hub.
        /// </summary>
        public AzureIotHubModuleIdentityDeleteTask(string deviceId = null ,  string moduleId = null)
        {
            WithArguments("az iot hub module-identity delete");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

WithArguments("--module-id");
            if (!string.IsNullOrEmpty(moduleId))
            {
                 WithArguments(moduleId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubModuleIdentityDeleteTask HubName(string hubName = null)
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
        public AzureIotHubModuleIdentityDeleteTask Login(string login = null)
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
        public AzureIotHubModuleIdentityDeleteTask ResourceGroup(string resourceGroup = null)
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
