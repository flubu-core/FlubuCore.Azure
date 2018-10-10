
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubDeviceIdentityCreateTask : ExternalProcessTaskBase<AzureIotHubDeviceIdentityCreateTask>
     {
        
        /// <summary>
        /// Create a device in an IoT Hub.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask(string deviceId = null)
        {
            WithArguments("az iot hub device-identity create");
WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The authorization type an entity is to be created with.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask Am(string am = null)
        {
            WithArguments("--am");
            if (!string.IsNullOrEmpty(am))
            {
                 WithArguments(am);
            }

            return this;
        }

        /// <summary>
        /// Flag indicating edge enablement.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask EdgeEnabled(string edgeEnabled = null)
        {
            WithArguments("--edge-enabled");
            if (!string.IsNullOrEmpty(edgeEnabled))
            {
                 WithArguments(edgeEnabled);
            }

            return this;
        }

        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask HubName(string hubName = null)
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
        public AzureIotHubDeviceIdentityCreateTask Login(string login = null)
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
        public AzureIotHubDeviceIdentityCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Set device status upon creation.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask Sta(string sta = null)
        {
            WithArguments("--sta");
            if (!string.IsNullOrEmpty(sta))
            {
                 WithArguments(sta);
            }

            return this;
        }

        /// <summary>
        /// Description for device status.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask Star(string star = null)
        {
            WithArguments("--star");
            if (!string.IsNullOrEmpty(star))
            {
                 WithArguments(star);
            }

            return this;
        }

        /// <summary>
        /// Generate self-signed cert and use its thumbprint. Output to specified target directory.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask Od(string od = null)
        {
            WithArguments("--od");
            if (!string.IsNullOrEmpty(od))
            {
                 WithArguments(od);
            }

            return this;
        }

        /// <summary>
        /// Explicit self-signed certificate thumbprint to use for primary key.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask PrimaryThumbprint(string primaryThumbprint = null)
        {
            WithArguments("--primary-thumbprint");
            if (!string.IsNullOrEmpty(primaryThumbprint))
            {
                 WithArguments(primaryThumbprint);
            }

            return this;
        }

        /// <summary>
        /// Explicit self-signed certificate thumbprint to use for secondary key.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask SecondaryThumbprint(string secondaryThumbprint = null)
        {
            WithArguments("--secondary-thumbprint");
            if (!string.IsNullOrEmpty(secondaryThumbprint))
            {
                 WithArguments(secondaryThumbprint);
            }

            return this;
        }

        /// <summary>
        /// Generate self-signed cert and use its thumbprint. Valid for specified number of days. Default: 365.
        /// </summary>
        public AzureIotHubDeviceIdentityCreateTask ValidDays(string validDays = null)
        {
            WithArguments("--valid-days");
            if (!string.IsNullOrEmpty(validDays))
            {
                 WithArguments(validDays);
            }

            return this;
        }
     }
}
