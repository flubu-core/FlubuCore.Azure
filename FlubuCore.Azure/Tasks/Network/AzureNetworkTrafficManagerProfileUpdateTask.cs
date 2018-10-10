
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerProfileUpdateTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerProfileUpdateTask>
     {
        
        /// <summary>
        /// Update a traffic manager profile.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network traffic-manager profile update");
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
        /// Routing method.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask RoutingMethod(string routingMethod = null)
        {
            WithArguments("--routing-method");
            if (!string.IsNullOrEmpty(routingMethod))
            {
                 WithArguments(routingMethod);
            }

            return this;
        }

        /// <summary>
        /// Status of the Traffic Manager profile.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask Status(string status = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Tags(string tags = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Ttl(string ttl = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Interval(string interval = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask MaxFailures(string maxFailures = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Path(string path = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Port(string port = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Protocol(string protocol = null)
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
        public AzureNetworkTrafficManagerProfileUpdateTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkTrafficManagerProfileUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
