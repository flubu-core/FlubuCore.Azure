
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmSecretRemoveTask : ExternalProcessTaskBase<AzureVmSecretRemoveTask>
     {
        
        /// <summary>
        /// Remove a secret from a VM.
        /// </summary>
        public AzureVmSecretRemoveTask(string keyvault = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm secret remove");
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
        /// Key vault certificate name or its full secret URL.
        /// </summary>
        public AzureVmSecretRemoveTask Certificate(string certificate = null)
        {
            WithArguments("--certificate");
            if (!string.IsNullOrEmpty(certificate))
            {
                 WithArguments(certificate);
            }

            return this;
        }
     }
}
