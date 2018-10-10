
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubQueryTask : ExternalProcessTaskBase<AzureIotHubQueryTask>
     {
        
        /// <summary>
        /// Query an IoT Hub using a powerful SQL-like language.
        /// </summary>
        public AzureIotHubQueryTask(string queryCommand = null)
        {
            WithArguments("az iot hub query");
WithArguments("--query-command");
            if (!string.IsNullOrEmpty(queryCommand))
            {
                 WithArguments(queryCommand);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// IoT Hub name.
        /// </summary>
        public AzureIotHubQueryTask HubName(string hubName = null)
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
        public AzureIotHubQueryTask Login(string login = null)
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
        public AzureIotHubQueryTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of elements to return. By default query has no cap.
        /// </summary>
        public AzureIotHubQueryTask Top(string top = null)
        {
            WithArguments("--top");
            if (!string.IsNullOrEmpty(top))
            {
                 WithArguments(top);
            }

            return this;
        }
     }
}
