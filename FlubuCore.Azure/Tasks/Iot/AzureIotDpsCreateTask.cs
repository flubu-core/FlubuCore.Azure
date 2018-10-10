
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsCreateTask : ExternalProcessTaskBase<AzureIotDpsCreateTask>
     {
        
        /// <summary>
        /// Create an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location of your IoT Provisioning Service. Default is the location of target resource group.
        /// </summary>
        public AzureIotDpsCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Pricing tier for the IoT provisioning service.
        /// </summary>
        public AzureIotDpsCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Units in your IoT Provisioning Service.
        /// </summary>
        public AzureIotDpsCreateTask Unit(string unit = null)
        {
            WithArguments("--unit");
            if (!string.IsNullOrEmpty(unit))
            {
                 WithArguments(unit);
            }

            return this;
        }
     }
}
