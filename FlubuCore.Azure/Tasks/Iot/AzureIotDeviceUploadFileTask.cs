
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceUploadFileTask : ExternalProcessTaskBase<AzureIotDeviceUploadFileTask>
     {
        
        /// <summary>
        /// Upload a local file as a device to a pre-configured blob storage container.
        /// </summary>
        public AzureIotDeviceUploadFileTask(string contentType = null ,  string deviceId = null ,  string filePath = null)
        {
            WithArguments("az iot device upload-file");
WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

WithArguments("--file-path");
            if (!string.IsNullOrEmpty(filePath))
            {
                 WithArguments(filePath);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotDeviceUploadFileTask HubName(string hubName = null)
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
        public AzureIotDeviceUploadFileTask Login(string login = null)
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
        public AzureIotDeviceUploadFileTask ResourceGroup(string resourceGroup = null)
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
