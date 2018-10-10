
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubCreateTask : ExternalProcessTaskBase<AzureIotHubCreateTask>
     {
        
        /// <summary>
        /// Create an Azure IoT hub.
        /// </summary>
        public AzureIotHubCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az iot hub create");
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
        /// Location of your IoT Hub. Default is the location of target resource group.
        /// </summary>
        public AzureIotHubCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The number of partitions of the backing Event Hub for device-to-cloud messages.
        /// </summary>
        public AzureIotHubCreateTask PartitionCount(string partitionCount = null)
        {
            WithArguments("--partition-count");
            if (!string.IsNullOrEmpty(partitionCount))
            {
                 WithArguments(partitionCount);
            }

            return this;
        }

        /// <summary>
        /// Pricing tier for Azure IoT Hub. Default value is F1, which is free. Note that only one free IoT hub instance is allowed in each subscription. Exception will be thrown if free instances exceed one.
        /// </summary>
        public AzureIotHubCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Units in your IoT Hub.
        /// </summary>
        public AzureIotHubCreateTask Unit(string unit = null)
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
