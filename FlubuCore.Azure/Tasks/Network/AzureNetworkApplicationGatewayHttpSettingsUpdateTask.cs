
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayHttpSettingsUpdateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayHttpSettingsUpdateTask>
     {
        
        /// <summary>
        /// Update HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway http-settings update");
WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
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
        /// Name used for the affinity cookie.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask AffinityCookieName(string affinityCookieName = null)
        {
            WithArguments("--affinity-cookie-name");
            if (!string.IsNullOrEmpty(affinityCookieName))
            {
                 WithArguments(affinityCookieName);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of authentication certificates (names or IDs) to associate with the HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask AuthCerts(string authCerts = null)
        {
            WithArguments("--auth-certs");
            if (!string.IsNullOrEmpty(authCerts))
            {
                 WithArguments(authCerts);
            }

            return this;
        }

        /// <summary>
        /// The time in seconds after a backend server is removed during which on open connection remains active. Range: 0 (disabled) to 3600.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask ConnectionDrainingTimeout(string connectionDrainingTimeout = null)
        {
            WithArguments("--connection-draining-timeout");
            if (!string.IsNullOrEmpty(connectionDrainingTimeout))
            {
                 WithArguments(connectionDrainingTimeout);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable cookie-based affinity.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask CookieBasedAffinity(string cookieBasedAffinity = null)
        {
            WithArguments("--cookie-based-affinity");
            if (!string.IsNullOrEmpty(cookieBasedAffinity))
            {
                 WithArguments(cookieBasedAffinity);
            }

            return this;
        }

        /// <summary>
        /// Whether the probe is enabled.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask EnableProbe(string enableProbe = null)
        {
            WithArguments("--enable-probe");
            if (!string.IsNullOrEmpty(enableProbe))
            {
                 WithArguments(enableProbe);
            }

            return this;
        }

        /// <summary>
        /// Host header sent to the backend servers.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask HostName(string hostName = null)
        {
            WithArguments("--host-name");
            if (!string.IsNullOrEmpty(hostName))
            {
                 WithArguments(hostName);
            }

            return this;
        }

        /// <summary>
        /// Use host name of the backend server as the host header.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask HostNameFromBackendPool(string hostNameFromBackendPool = null)
        {
            WithArguments("--host-name-from-backend-pool");
            if (!string.IsNullOrEmpty(hostNameFromBackendPool))
            {
                 WithArguments(hostNameFromBackendPool);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Path that will prefix all HTTP requests.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// The port number.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Port(string port = null)
        {
            WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the probe to associate with the HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Probe(string probe = null)
        {
            WithArguments("--probe");
            if (!string.IsNullOrEmpty(probe))
            {
                 WithArguments(probe);
            }

            return this;
        }

        /// <summary>
        /// The HTTP settings protocol.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Timeout(string timeout = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Add(string add = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Remove(string remove = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsUpdateTask Set(string set = null)
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
