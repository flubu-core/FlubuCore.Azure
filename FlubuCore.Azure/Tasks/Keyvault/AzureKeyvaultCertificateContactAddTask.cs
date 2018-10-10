
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateContactAddTask : ExternalProcessTaskBase<AzureKeyvaultCertificateContactAddTask>
     {
        
        /// <summary>
        /// Add a contact to the specified vault to receive notifications of certificate operations.
        /// </summary>
        public AzureKeyvaultCertificateContactAddTask(string email = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate contact add");
WithArguments("--email");
            if (!string.IsNullOrEmpty(email))
            {
                 WithArguments(email);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Full contact name.
        /// </summary>
        public AzureKeyvaultCertificateContactAddTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Contact phone number.
        /// </summary>
        public AzureKeyvaultCertificateContactAddTask Phone(string phone = null)
        {
            WithArguments("--phone");
            if (!string.IsNullOrEmpty(phone))
            {
                 WithArguments(phone);
            }

            return this;
        }
     }
}
