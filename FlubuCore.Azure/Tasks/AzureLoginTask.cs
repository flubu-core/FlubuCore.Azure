
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureLoginTask : ExternalProcessTaskBase<AzureLoginTask>
     {
        
        /// <summary>
        /// Log in to Azure.
        /// </summary>
        public AzureLoginTask()
        {
            WithArguments("az login");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.
        /// </summary>
        public AzureLoginTask AllowNoSubscriptions(string allowNoSubscriptions = null)
        {
            WithArguments("--allow-no-subscriptions");
            if (!string.IsNullOrEmpty(allowNoSubscriptions))
            {
                 WithArguments(allowNoSubscriptions);
            }

            return this;
        }

        /// <summary>
        /// Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.
        /// </summary>
        public AzureLoginTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The credential representing a service principal.
        /// </summary>
        public AzureLoginTask ServicePrincipal(string servicePrincipal = null)
        {
            WithArguments("--service-principal");
            if (!string.IsNullOrEmpty(servicePrincipal))
            {
                 WithArguments(servicePrincipal);
            }

            return this;
        }

        /// <summary>
        /// The AAD tenant, must provide when using service principals.
        /// </summary>
        public AzureLoginTask Tenant(string tenant = null)
        {
            WithArguments("--tenant");
            if (!string.IsNullOrEmpty(tenant))
            {
                 WithArguments(tenant);
            }

            return this;
        }

        /// <summary>
        /// Use CLI's old authentication flow based on device code. CLI will also use this if it can't launch a browser in your behalf, e.g. in remote SSH or Cloud Shell.
        /// </summary>
        public AzureLoginTask UseDeviceCode(string useDeviceCode = null)
        {
            WithArguments("--use-device-code");
            if (!string.IsNullOrEmpty(useDeviceCode))
            {
                 WithArguments(useDeviceCode);
            }

            return this;
        }

        /// <summary>
        /// User name, service principal, or managed service identity ID.
        /// </summary>
        public AzureLoginTask Username(string username = null)
        {
            WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

            return this;
        }

        /// <summary>
        /// Log in using the Virtual Machine's identity.
        /// </summary>
        public AzureLoginTask Identity(string identity = null)
        {
            WithArguments("--identity");
            if (!string.IsNullOrEmpty(identity))
            {
                 WithArguments(identity);
            }

            return this;
        }
     }
}
