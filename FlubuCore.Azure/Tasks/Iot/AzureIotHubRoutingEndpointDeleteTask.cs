
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRoutingEndpointDeleteTask : ExternalProcessTaskBase<AzureIotHubRoutingEndpointDeleteTask>
     {
        
        /// <summary>
        /// Delete all or mentioned endpoint for your IoT Hub.
        /// </summary>
        public AzureIotHubRoutingEndpointDeleteTask(string hubName = null)
        {
            WithArguments("az iot hub routing-endpoint delete");
WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the Routing Endpoint.
        /// </summary>
        public AzureIotHubRoutingEndpointDeleteTask EndpointName(string endpointName = null)
        {
            WithArguments("--endpoint-name");
            if (!string.IsNullOrEmpty(endpointName))
            {
                 WithArguments(endpointName);
            }

            return this;
        }

        /// <summary>
        /// Type of the Routing Endpoint.
        /// </summary>
        public AzureIotHubRoutingEndpointDeleteTask EndpointType(string endpointType = null)
        {
            WithArguments("--endpoint-type");
            if (!string.IsNullOrEmpty(endpointType))
            {
                 WithArguments(endpointType);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubRoutingEndpointDeleteTask ResourceGroup(string resourceGroup = null)
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
