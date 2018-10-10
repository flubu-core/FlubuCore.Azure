
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountSpResetCredentialsTask : ExternalProcessTaskBase<AzureAmsAccountSpResetCredentialsTask>
     {
        
        /// <summary>
        /// Generate a new client secret for a service principal configured for an Azure Media Services account.
        /// </summary>
        public AzureAmsAccountSpResetCredentialsTask(string accountName = null ,  string resourceGroup = null)
        {
            WithArguments("az ams account sp reset-credentials");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.
        /// </summary>
        public AzureAmsAccountSpResetCredentialsTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.
        /// </summary>
        public AzureAmsAccountSpResetCredentialsTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The role of the service principal.
        /// </summary>
        public AzureAmsAccountSpResetCredentialsTask Role(string role = null)
        {
            WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

            return this;
        }

        /// <summary>
        /// Enables xml output format.
        /// </summary>
        public AzureAmsAccountSpResetCredentialsTask Xml(string xml = null)
        {
            WithArguments("--xml");
            if (!string.IsNullOrEmpty(xml))
            {
                 WithArguments(xml);
            }

            return this;
        }

        /// <summary>
        /// Number of years for which the secret will be valid. Default: 1 year.
        /// </summary>
        public AzureAmsAccountSpResetCredentialsTask Years(string years = null)
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
