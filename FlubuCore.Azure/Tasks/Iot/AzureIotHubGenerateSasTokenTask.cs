
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubGenerateSasTokenTask : ExternalProcessTaskBase<AzureIotHubGenerateSasTokenTask>
     {
        
        /// <summary>
        /// Generate a SAS token for a target IoT Hub or device.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask()
        {
            WithArguments("az iot hub generate-sas-token");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Target Device.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask DeviceId(string deviceId = null)
        {
            WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

            return this;
        }

        /// <summary>
        /// Valid token duration in seconds.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask Du(string du = null)
        {
            WithArguments("--du");
            if (!string.IsNullOrEmpty(du))
            {
                 WithArguments(du);
            }

            return this;
        }

        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask HubName(string hubName = null)
        {
            WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

            return this;
        }

        /// <summary>
        /// Shared access policy key type for auth.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask KeyType(string keyType = null)
        {
            WithArguments("--key-type");
            if (!string.IsNullOrEmpty(keyType))
            {
                 WithArguments(keyType);
            }

            return this;
        }

        /// <summary>
        /// This command supports an entity connection string with rights to perform action. Use to avoid session login via "az login". If both an entity connection string and name are provided the connection string takes priority.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask Login(string login = null)
        {
            WithArguments("--login");
            if (!string.IsNullOrEmpty(login))
            {
                 WithArguments(login);
            }

            return this;
        }

        /// <summary>
        /// Shared access policy with operation permissions for target IoT Hub entity.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask Pn(string pn = null)
        {
            WithArguments("--pn");
            if (!string.IsNullOrEmpty(pn))
            {
                 WithArguments(pn);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubGenerateSasTokenTask ResourceGroup(string resourceGroup = null)
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
