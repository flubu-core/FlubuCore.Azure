
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogCredentialDeleteTask : ExternalProcessTaskBase<AzureDlaCatalogCredentialDeleteTask>
     {
        
        /// <summary>
        /// Delete a catalog credential.
        /// </summary>
        public AzureDlaCatalogCredentialDeleteTask(string account = null ,  string credentialName = null ,  string databaseName = null)
        {
            WithArguments("az dla catalog credential delete");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates if the delete should be a cascading delete (which deletes all resources dependent on the credential as well as the credential) or not. If false will fail if there are any resources relying on the credential.
        /// </summary>
        public AzureDlaCatalogCredentialDeleteTask Cascade(string cascade = null)
        {
            WithArguments("--cascade");
            if (!string.IsNullOrEmpty(cascade))
            {
                 WithArguments(cascade);
            }

            return this;
        }

        /// <summary>
        /// The current password for the credential and user with access to the data source. This is required if the requester is not the account owner.
        /// </summary>
        public AzureDlaCatalogCredentialDeleteTask Password(string password = null)
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
