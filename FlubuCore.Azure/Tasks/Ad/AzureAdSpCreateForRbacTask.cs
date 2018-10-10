
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpCreateForRbacTask : ExternalProcessTaskBase<AzureAdSpCreateForRbacTask>
     {
        
        /// <summary>
        /// Create a service principal and configure its access to Azure resources.
        /// </summary>
        public AzureAdSpCreateForRbacTask()
        {
            WithArguments("az ad sp create-for-rbac");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name or app URI to associate the RBAC with. If not present, a name will be generated.
        /// </summary>
        public AzureAdSpCreateForRbacTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Role of the service principal.
        /// </summary>
        public AzureAdSpCreateForRbacTask Role(string role = null)
        {
            WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.
        /// </summary>
        public AzureAdSpCreateForRbacTask Scopes(string scopes = null)
        {
            WithArguments("--scopes");
            if (!string.IsNullOrEmpty(scopes))
            {
                 WithArguments(scopes);
            }

            return this;
        }

        /// <summary>
        /// Output result in compatible with Azure SDK auth file.
        /// </summary>
        public AzureAdSpCreateForRbacTask SdkAuth(string sdkAuth = null)
        {
            WithArguments("--sdk-auth");
            if (!string.IsNullOrEmpty(sdkAuth))
            {
                 WithArguments(sdkAuth);
            }

            return this;
        }

        /// <summary>
        /// Do not create default assignment.
        /// </summary>
        public AzureAdSpCreateForRbacTask SkipAssignment(string skipAssignment = null)
        {
            WithArguments("--skip-assignment");
            if (!string.IsNullOrEmpty(skipAssignment))
            {
                 WithArguments(skipAssignment);
            }

            return this;
        }

        /// <summary>
        /// Certificate to use for credentials.
        /// </summary>
        public AzureAdSpCreateForRbacTask Cert(string cert = null)
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
        public AzureAdSpCreateForRbacTask CreateCert(string createCert = null)
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
        public AzureAdSpCreateForRbacTask Keyvault(string keyvault = null)
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
        public AzureAdSpCreateForRbacTask Password(string password = null)
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
        public AzureAdSpCreateForRbacTask Years(string years = null)
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
