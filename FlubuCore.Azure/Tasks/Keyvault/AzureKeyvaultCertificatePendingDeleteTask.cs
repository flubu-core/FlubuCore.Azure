
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificatePendingDeleteTask : ExternalProcessTaskBase<AzureKeyvaultCertificatePendingDeleteTask>
     {
        
        /// <summary>
        /// Deletes the creation operation for a specific certificate.
        /// </summary>
        public AzureKeyvaultCertificatePendingDeleteTask(string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate pending delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
