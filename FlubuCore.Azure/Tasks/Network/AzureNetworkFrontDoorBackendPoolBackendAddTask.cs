
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorBackendPoolBackendAddTask : ExternalProcessTaskBase<AzureNetworkFrontDoorBackendPoolBackendAddTask>
     {
        
        /// <summary>
        /// Add a backend to a FrontDoor backend pool.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolBackendAddTask(string address = null ,  string frontDoorName = null ,  string poolName = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door backend-pool backend add");
WithArguments("--address");
            if (!string.IsNullOrEmpty(address))
            {
                 WithArguments(address);
            }

WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--pool-name");
            if (!string.IsNullOrEmpty(poolName))
            {
                 WithArguments(poolName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Host header sent to the backend.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolBackendAddTask BackendHostHeader(string backendHostHeader = null)
        {
            WithArguments("--backend-host-header");
            if (!string.IsNullOrEmpty(backendHostHeader))
            {
                 WithArguments(backendHostHeader);
            }

            return this;
        }

        /// <summary>
        /// Create in a disabled state.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolBackendAddTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// HTTP TCP port number.
        /// </summary>
        public AzureNetworkFrontDoorBackendPoolBackendAddTask HttpPort(string httpPort = null)
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
        public AzureNetworkFrontDoorBackendPoolBackendAddTask HttpsPort(string httpsPort = null)
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
        public AzureNetworkFrontDoorBackendPoolBackendAddTask Priority(string priority = null)
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
        public AzureNetworkFrontDoorBackendPoolBackendAddTask Weight(string weight = null)
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
