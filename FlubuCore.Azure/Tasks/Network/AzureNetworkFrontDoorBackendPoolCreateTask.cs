
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorBackendPoolCreateTask : ExternalProcessTaskBase<AzureNetworkFrontDoorBackendPoolCreateTask>
     {
        
        /// <summary>
        /// Create a FrontDoor backend pool.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask(string frontDoorName = null ,  string loadBalancing = null ,  string name = null ,  string probe = null ,  string resourceGroup = null ,  string address = null)
        {
            WithArguments("az network front-door backend-pool create");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--load-balancing");
            if (!string.IsNullOrEmpty(loadBalancing))
            {
                 WithArguments(loadBalancing);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--probe");
            if (!string.IsNullOrEmpty(probe))
            {
                 WithArguments(probe);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--address");
            if (!string.IsNullOrEmpty(address))
            {
                 WithArguments(address);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create in a disabled state.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Host header sent to the backend.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask BackendHostHeader(string backendHostHeader = null)
        {
            WithArguments("--backend-host-header");
            if (!string.IsNullOrEmpty(backendHostHeader))
            {
                 WithArguments(backendHostHeader);
            }

            return this;
        }

        /// <summary>
        /// HTTP TCP port number.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask HttpPort(string httpPort = null)
        {
            WithArguments("--http-port");
            if (!string.IsNullOrEmpty(httpPort))
            {
                 WithArguments(httpPort);
            }

            return this;
        }

        /// <summary>
        /// HTTPS TCP port number.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask HttpsPort(string httpsPort = null)
        {
            WithArguments("--https-port");
            if (!string.IsNullOrEmpty(httpsPort))
            {
                 WithArguments(httpsPort);
            }

            return this;
        }

        /// <summary>
        /// Priority to use for load balancing. Higher priorities will not be used for load balancing if any lower priority backend is healthy.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// Weight of this endpoint for load balancing purposes.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolCreateTask Weight(string weight = null)
        {
            WithArguments("--weight");
            if (!string.IsNullOrEmpty(weight))
            {
                 WithArguments(weight);
            }

            return this;
        }
     }
}
