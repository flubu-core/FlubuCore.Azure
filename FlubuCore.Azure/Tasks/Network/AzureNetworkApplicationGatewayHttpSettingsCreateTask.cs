
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayHttpSettingsCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayHttpSettingsCreateTask>
     {
        
        /// <summary>
        /// Create HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask(string gatewayName = null ,  string name = null ,  string port = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway http-settings create");
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

WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask AffinityCookieName(string affinityCookieName = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask AuthCerts(string authCerts = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask ConnectionDrainingTimeout(string connectionDrainingTimeout = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask CookieBasedAffinity(string cookieBasedAffinity = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask EnableProbe(string enableProbe = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask HostName(string hostName = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask HostNameFromBackendPool(string hostNameFromBackendPool = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask NoWait(string noWait = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the probe to associate with the HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask Probe(string probe = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask Protocol(string protocol = null)
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
        public AzureNetworkApplicationGatewayHttpSettingsCreateTask Timeout(string timeout = null)
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
