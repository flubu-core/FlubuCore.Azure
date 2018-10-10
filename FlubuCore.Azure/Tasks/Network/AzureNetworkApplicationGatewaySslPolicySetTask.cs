
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewaySslPolicySetTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewaySslPolicySetTask>
     {
        
        /// <summary>
        /// Update or clear SSL policy settings.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask(string gatewayName = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway ssl-policy set");
WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Ssl cipher suites to be enabled in the specified order to application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask CipherSuites(string cipherSuites = null)
        {
            WithArguments("--cipher-suites");
            if (!string.IsNullOrEmpty(cipherSuites))
            {
                 WithArguments(cipherSuites);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of protocols to disable.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask DisabledSslProtocols(string disabledSslProtocols = null)
        {
            WithArguments("--disabled-ssl-protocols");
            if (!string.IsNullOrEmpty(disabledSslProtocols))
            {
                 WithArguments(disabledSslProtocols);
            }

            return this;
        }

        /// <summary>
        /// Minimum version of Ssl protocol to be supported on application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask MinProtocolVersion(string minProtocolVersion = null)
        {
            WithArguments("--min-protocol-version");
            if (!string.IsNullOrEmpty(minProtocolVersion))
            {
                 WithArguments(minProtocolVersion);
            }

            return this;
        }

        /// <summary>
        /// Name of Ssl predefined policy.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Type of Ssl Policy.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicySetTask PolicyType(string policyType = null)
        {
            WithArguments("--policy-type");
            if (!string.IsNullOrEmpty(policyType))
            {
                 WithArguments(policyType);
            }

            return this;
        }
     }
}
