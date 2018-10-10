
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsLinkedHubCreateTask : ExternalProcessTaskBase<AzureIotDpsLinkedHubCreateTask>
     {
        
        /// <summary>
        /// Create a linked IoT hub in an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsLinkedHubCreateTask(string connectionString = null ,  string dpsName = null ,  string location = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps linked-hub create");
WithArguments("--connection-string");
            if (!string.IsNullOrEmpty(connectionString))
            {
                 WithArguments(connectionString);
            }

WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Allocation weight of the IoT hub.
        /// </summary>
        public AzureIotDpsLinkedHubCreateTask AllocationWeight(string allocationWeight = null)
        {
            WithArguments("--allocation-weight");
            if (!string.IsNullOrEmpty(allocationWeight))
            {
                 WithArguments(allocationWeight);
            }

            return this;
        }

        /// <summary>
        /// A boolean indicating whether to apply allocation policy to the IoT hub.
        /// </summary>
        public AzureIotDpsLinkedHubCreateTask ApplyAllocationPolicy(string applyAllocationPolicy = null)
        {
            WithArguments("--apply-allocation-policy");
            if (!string.IsNullOrEmpty(applyAllocationPolicy))
            {
                 WithArguments(applyAllocationPolicy);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureIotDpsLinkedHubCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
