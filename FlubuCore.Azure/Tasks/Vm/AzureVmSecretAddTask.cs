
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmSecretAddTask : ExternalProcessTaskBase<AzureVmSecretAddTask>
     {
        
        /// <summary>
        /// Add a secret to a VM.
        /// </summary>
        public AzureVmSecretAddTask(string certificate = null ,  string keyvault = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm secret add");
WithArguments("--certificate");
            if (!string.IsNullOrEmpty(certificate))
            {
                 WithArguments(certificate);
            }

WithArguments("--keyvault");
            if (!string.IsNullOrEmpty(keyvault))
            {
                 WithArguments(keyvault);
            }

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
        /// Windows certificate store names. Default: My.
        /// </summary>
        public AzureVmSecretAddTask CertificateStore(string certificateStore = null)
        {
            WithArguments("--certificate-store");
            if (!string.IsNullOrEmpty(certificateStore))
            {
                 WithArguments(certificateStore);
            }

            return this;
        }
     }
}
