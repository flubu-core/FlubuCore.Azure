
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateGetDefaultPolicyTask : ExternalProcessTaskBase<AzureKeyvaultCertificateGetDefaultPolicyTask>
     {
        
        /// <summary>
        /// Get the default policy for self-signed certificates.
        /// </summary>
        public AzureKeyvaultCertificateGetDefaultPolicyTask()
        {
            WithArguments("az keyvault certificate get-default-policy");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create a fully formed policy structure with default values.
        /// </summary>
        public AzureKeyvaultCertificateGetDefaultPolicyTask Scaffold(string scaffold = null)
        {
            WithArguments("--scaffold");
            if (!string.IsNullOrEmpty(scaffold))
            {
                 WithArguments(scaffold);
            }

            return this;
        }
     }
}
