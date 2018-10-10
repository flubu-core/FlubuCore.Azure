
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmSecretFormatTask : ExternalProcessTaskBase<AzureVmSecretFormatTask>
     {
        
        /// <summary>
        /// Transform secrets into a form that can be used by VMs and VMSSes.
        /// </summary>
        public AzureVmSecretFormatTask(string secrets = null)
        {
            WithArguments("az vm secret format");
WithArguments("--secrets");
            if (!string.IsNullOrEmpty(secrets))
            {
                 WithArguments(secrets);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Windows certificate store names. Default: My.
        /// </summary>
        public AzureVmSecretFormatTask CertificateStore(string certificateStore = null)
        {
            WithArguments("--certificate-store");
            if (!string.IsNullOrEmpty(certificateStore))
            {
                 WithArguments(certificateStore);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the key vault.
        /// </summary>
        public AzureVmSecretFormatTask Keyvault(string keyvault = null)
        {
            WithArguments("--keyvault");
            if (!string.IsNullOrEmpty(keyvault))
            {
                 WithArguments(keyvault);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureVmSecretFormatTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
