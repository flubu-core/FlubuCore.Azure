
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRoutingEndpointCreateTask : ExternalProcessTaskBase<AzureIotHubRoutingEndpointCreateTask>
     {
        
        /// <summary>
        /// Add an endpoint to your IoT Hub.
        /// </summary>
        public AzureIotHubRoutingEndpointCreateTask(string connectionString = null ,  string endpointName = null ,  string endpointResourceGroup = null ,  string endpointSubscriptionId = null ,  string endpointType = null ,  string hubName = null)
        {
            WithArguments("az iot hub routing-endpoint create");
WithArguments("--connection-string");
            if (!string.IsNullOrEmpty(connectionString))
            {
                 WithArguments(connectionString);
            }

WithArguments("--endpoint-name");
            if (!string.IsNullOrEmpty(endpointName))
            {
                 WithArguments(endpointName);
            }

WithArguments("--endpoint-resource-group");
            if (!string.IsNullOrEmpty(endpointResourceGroup))
            {
                 WithArguments(endpointResourceGroup);
            }

WithArguments("--endpoint-subscription-id");
            if (!string.IsNullOrEmpty(endpointSubscriptionId))
            {
                 WithArguments(endpointSubscriptionId);
            }

WithArguments("--endpoint-type");
            if (!string.IsNullOrEmpty(endpointType))
            {
                 WithArguments(endpointType);
            }

WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the storage container.
        /// </summary>
        public AzureIotHubRoutingEndpointCreateTask Container(string container = null)
        {
            WithArguments("--container");
            if (!string.IsNullOrEmpty(container))
            {
                 WithArguments(container);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubRoutingEndpointCreateTask ResourceGroup(string resourceGroup = null)
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
