
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogCredentialUpdateTask : ExternalProcessTaskBase<AzureDlaCatalogCredentialUpdateTask>
     {
        
        /// <summary>
        /// Update a catalog credential for use with an external data source.
        /// </summary>
        public AzureDlaCatalogCredentialUpdateTask(string account = null ,  string credentialName = null ,  string databaseName = null ,  string uri = null ,  string userName = null)
        {
            WithArguments("az dla catalog credential update");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--credential-name");
            if (!string.IsNullOrEmpty(credentialName))
            {
                 WithArguments(credentialName);
            }

WithArguments("--database-name");
            if (!string.IsNullOrEmpty(databaseName))
            {
                 WithArguments(databaseName);
            }

WithArguments("--uri");
            if (!string.IsNullOrEmpty(uri))
            {
                 WithArguments(uri);
            }

WithArguments("--user-name");
            if (!string.IsNullOrEmpty(userName))
            {
                 WithArguments(userName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// New password for the credential user. Will prompt if not given.
        /// </summary>
        public AzureDlaCatalogCredentialUpdateTask NewPassword(string newPassword = null)
        {
            WithArguments("--new-password");
            if (!string.IsNullOrEmpty(newPassword))
            {
                 WithArguments(newPassword);
            }

            return this;
        }

        /// <summary>
        /// Current password for the credential user. Will prompt if not given.
        /// </summary>
        public AzureDlaCatalogCredentialUpdateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }
     }
}
