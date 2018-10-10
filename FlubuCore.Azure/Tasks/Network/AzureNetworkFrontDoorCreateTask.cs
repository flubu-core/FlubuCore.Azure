
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorCreateTask : ExternalProcessTaskBase<AzureNetworkFrontDoorCreateTask>
     {
        
        /// <summary>
        /// Create a FrontDoor.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask(string name = null ,  string resourceGroup = null ,  string backendAddress = null)
        {
            WithArguments("az network front-door create");
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

WithArguments("--backend-address");
            if (!string.IsNullOrEmpty(backendAddress))
            {
                 WithArguments(backendAddress);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create in a disabled state.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Friendly name of the FrontDoor.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask FriendlyName(string friendlyName = null)
        {
            WithArguments("--friendly-name");
            if (!string.IsNullOrEmpty(friendlyName))
            {
                 WithArguments(friendlyName);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Host header sent to the backend.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask BackendHostHeader(string backendHostHeader = null)
        {
            WithArguments("--backend-host-header");
            if (!string.IsNullOrEmpty(backendHostHeader))
            {
                 WithArguments(backendHostHeader);
            }

            return this;
        }

        /// <summary>
        /// Domain name of the frontend endpoint.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask FrontendHostName(string frontendHostName = null)
        {
            WithArguments("--frontend-host-name");
            if (!string.IsNullOrEmpty(frontendHostName))
            {
                 WithArguments(frontendHostName);
            }

            return this;
        }

        /// <summary>
        /// Interval in seconds between probes.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask Interval(string interval = null)
        {
            WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

            return this;
        }

        /// <summary>
        /// Path to probe.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// Protocol to use for sending probes.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of protocols to accept. Default: Http.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask AcceptedProtocols(string acceptedProtocols = null)
        {
            WithArguments("--accepted-protocols");
            if (!string.IsNullOrEmpty(acceptedProtocols))
            {
                 WithArguments(acceptedProtocols);
            }

            return this;
        }

        /// <summary>
        /// Protocol to use for forwarding traffic.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask ForwardingProtocol(string forwardingProtocol = null)
        {
            WithArguments("--forwarding-protocol");
            if (!string.IsNullOrEmpty(forwardingProtocol))
            {
                 WithArguments(forwardingProtocol);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of patterns to match. Default: '/*'.
        /// </summary>
        public AzureNetworkFrontDoorCreateTask Patterns(string patterns = null)
        {
            WithArguments("--patterns");
            if (!string.IsNullOrEmpty(patterns))
            {
                 WithArguments(patterns);
            }

            return this;
        }
     }
}
