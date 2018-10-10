
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewaySslCertUpdateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewaySslCertUpdateTask>
     {
        
        /// <summary>
        /// Update an SSL certificate.
        /// </summary>
        public AzureNetworkApplicationGatewaySslCertUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway ssl-cert update");
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
        /// The path to the PFX certificate file.
        /// </summary>
        public AzureNetworkApplicationGatewaySslCertUpdateTask CertFile(string certFile = null)
        {
            WithArguments("--cert-file");
            if (!string.IsNullOrEmpty(certFile))
            {
                 WithArguments(certFile);
            }

            return this;
        }

        /// <summary>
        /// Certificate password.
        /// </summary>
        public AzureNetworkApplicationGatewaySslCertUpdateTask CertPassword(string certPassword = null)
        {
            WithArguments("--cert-password");
            if (!string.IsNullOrEmpty(certPassword))
            {
                 WithArguments(certPassword);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewaySslCertUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkApplicationGatewaySslCertUpdateTask Add(string add = null)
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
        public AzureNetworkApplicationGatewaySslCertUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkApplicationGatewaySslCertUpdateTask Remove(string remove = null)
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
        public AzureNetworkApplicationGatewaySslCertUpdateTask Set(string set = null)
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
