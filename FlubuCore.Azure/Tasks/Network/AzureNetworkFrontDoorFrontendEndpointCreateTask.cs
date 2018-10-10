
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorFrontendEndpointCreateTask : ExternalProcessTaskBase<AzureNetworkFrontDoorFrontendEndpointCreateTask>
     {
        
        /// <summary>
        /// Create a FrontDoor frontend endpoint.
        /// </summary>
        public AzureNetworkFrontDoorFrontendEndpointCreateTask(string frontDoorName = null ,  string hostName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door frontend-endpoint create");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--host-name");
            if (!string.IsNullOrEmpty(hostName))
            {
                 WithArguments(hostName);
            }

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
        /// Whether to allow session affinity on this host.
        /// </summary>
        public AzureNetworkFrontDoorFrontendEndpointCreateTask SessionAffinityEnabled(string sessionAffinityEnabled = null)
        {
            WithArguments("--session-affinity-enabled");
            if (!string.IsNullOrEmpty(sessionAffinityEnabled))
            {
                 WithArguments(sessionAffinityEnabled);
            }

            return this;
        }

        /// <summary>
        /// The TTL to use in seconds for session affinity.
        /// </summary>
        public AzureNetworkFrontDoorFrontendEndpointCreateTask SessionAffinityTtl(string sessionAffinityTtl = null)
        {
            WithArguments("--session-affinity-ttl");
            if (!string.IsNullOrEmpty(sessionAffinityTtl))
            {
                 WithArguments(sessionAffinityTtl);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a web application firewall policy.
        /// </summary>
        public AzureNetworkFrontDoorFrontendEndpointCreateTask WafPolicy(string wafPolicy = null)
        {
            WithArguments("--waf-policy");
            if (!string.IsNullOrEmpty(wafPolicy))
            {
                 WithArguments(wafPolicy);
            }

            return this;
        }
     }
}
