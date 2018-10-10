
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerProfileCreateTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerProfileCreateTask>
     {
        
        /// <summary>
        /// Create a traffic manager profile.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask(string name = null ,  string resourceGroup = null ,  string routingMethod = null ,  string uniqueDnsName = null)
        {
            WithArguments("az network traffic-manager profile create");
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

WithArguments("--routing-method");
            if (!string.IsNullOrEmpty(routingMethod))
            {
                 WithArguments(routingMethod);
            }

WithArguments("--unique-dns-name");
            if (!string.IsNullOrEmpty(uniqueDnsName))
            {
                 WithArguments(uniqueDnsName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Status of the Traffic Manager profile.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// DNS config time-to-live in seconds.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Ttl(string ttl = null)
        {
            WithArguments("--ttl");
            if (!string.IsNullOrEmpty(ttl))
            {
                 WithArguments(ttl);
            }

            return this;
        }

        /// <summary>
        /// The interval in seconds at which health checks are conducted.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Interval(string interval = null)
        {
            WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

            return this;
        }

        /// <summary>
        /// The number of consecutive failed health checks tolerated before an endpoint is considered degraded.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask MaxFailures(string maxFailures = null)
        {
            WithArguments("--max-failures");
            if (!string.IsNullOrEmpty(maxFailures))
            {
                 WithArguments(maxFailures);
            }

            return this;
        }

        /// <summary>
        /// Path to monitor. Use "" for none.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// Port to monitor.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Port(string port = null)
        {
            WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

            return this;
        }

        /// <summary>
        /// Monitor protocol.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// The time in seconds allowed for endpoints to response to a health check.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCreateTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }
     }
}
