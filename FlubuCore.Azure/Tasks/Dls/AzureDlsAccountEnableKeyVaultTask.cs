
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountEnableKeyVaultTask : ExternalProcessTaskBase<AzureDlsAccountEnableKeyVaultTask>
     {
        
        /// <summary>
        /// Enable the use of Azure Key Vault for encryption of a Data Lake Store account.
        /// </summary>
        public AzureDlsAccountEnableKeyVaultTask(string account = null)
        {
            WithArguments("az dls account enable-key-vault");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Store account.
        /// </summary>
        public AzureDlsAccountEnableKeyVaultTask ResourceGroup(string resourceGroup = null)
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
