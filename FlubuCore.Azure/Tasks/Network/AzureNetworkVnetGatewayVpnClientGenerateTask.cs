
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayVpnClientGenerateTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayVpnClientGenerateTask>
     {
        
        /// <summary>
        /// Generate VPN client configuration.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientGenerateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet-gateway vpn-client generate");
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
        /// Method used to authenticate with the generated client.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientGenerateTask AuthenticationMethod(string authenticationMethod = null)
        {
            WithArguments("--authentication-method");
            if (!string.IsNullOrEmpty(authenticationMethod))
            {
                 WithArguments(authenticationMethod);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of client root certificate public certificate data in Base-64 format. Optional for external Radius-based auth with EAPTLS.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientGenerateTask ClientRootCertificates(string clientRootCertificates = null)
        {
            WithArguments("--client-root-certificates");
            if (!string.IsNullOrEmpty(clientRootCertificates))
            {
                 WithArguments(clientRootCertificates);
            }

            return this;
        }

        /// <summary>
        /// Processor architecture of the target system.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientGenerateTask ProcessorArchitecture(string processorArchitecture = null)
        {
            WithArguments("--processor-architecture");
            if (!string.IsNullOrEmpty(processorArchitecture))
            {
                 WithArguments(processorArchitecture);
            }

            return this;
        }

        /// <summary>
        /// Public certificate data for the Radius server auth certificate in Base-64 format. Required only if external Radius auth has been configured with EAPTLS auth.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientGenerateTask RadiusServerAuthCertificate(string radiusServerAuthCertificate = null)
        {
            WithArguments("--radius-server-auth-certificate");
            if (!string.IsNullOrEmpty(radiusServerAuthCertificate))
            {
                 WithArguments(radiusServerAuthCertificate);
            }

            return this;
        }

        /// <summary>
        /// Generate VPN client package using legacy implementation.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientGenerateTask UseLegacy(string useLegacy = null)
        {
            WithArguments("--use-legacy");
            if (!string.IsNullOrEmpty(useLegacy))
            {
                 WithArguments(useLegacy);
            }

            return this;
        }
     }
}
