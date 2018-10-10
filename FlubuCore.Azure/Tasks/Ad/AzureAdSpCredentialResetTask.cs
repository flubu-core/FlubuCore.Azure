
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpCredentialResetTask : ExternalProcessTaskBase<AzureAdSpCredentialResetTask>
     {
        
        /// <summary>
        /// Reset a service principal credential.
        /// </summary>
        public AzureAdSpCredentialResetTask(string name = null)
        {
            WithArguments("az ad sp credential reset");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Append the new credential instead of overwriting.
        /// </summary>
        public AzureAdSpCredentialResetTask Append(string append = null)
        {
            WithArguments("--append");
            if (!string.IsNullOrEmpty(append))
            {
                 WithArguments(append);
            }

            return this;
        }

        /// <summary>
        /// Certificate to use for credentials.
        /// </summary>
        public AzureAdSpCredentialResetTask Cert(string cert = null)
        {
            WithArguments("--cert");
            if (!string.IsNullOrEmpty(cert))
            {
                 WithArguments(cert);
            }

            return this;
        }

        /// <summary>
        /// Create a self-signed certificate to use for the credential.
        /// </summary>
        public AzureAdSpCredentialResetTask CreateCert(string createCert = null)
        {
            WithArguments("--create-cert");
            if (!string.IsNullOrEmpty(createCert))
            {
                 WithArguments(createCert);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a KeyVault to use for creating or retrieving certificates.
        /// </summary>
        public AzureAdSpCredentialResetTask Keyvault(string keyvault = null)
        {
            WithArguments("--keyvault");
            if (!string.IsNullOrEmpty(keyvault))
            {
                 WithArguments(keyvault);
            }

            return this;
        }

        /// <summary>
        /// The password used to log in.
        /// </summary>
        public AzureAdSpCredentialResetTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Number of years for which the credentials will be valid. Default: 1 year.
        /// </summary>
        public AzureAdSpCredentialResetTask Years(string years = null)
        {
            WithArguments("--years");
            if (!string.IsNullOrEmpty(years))
            {
                 WithArguments(years);
            }

            return this;
        }
     }
}
