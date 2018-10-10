
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountTrustedProviderDeleteTask : ExternalProcessTaskBase<AzureDlsAccountTrustedProviderDeleteTask>
     {
        
        /// <summary>
        /// Deletes the specified trusted identity provider from the specified Data Lake Store account.
        /// </summary>
        public AzureDlsAccountTrustedProviderDeleteTask(string account = null ,  string trustedIdProviderName = null)
        {
            WithArguments("az dls account trusted-provider delete");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--trusted-id-provider-name");
            if (!string.IsNullOrEmpty(trustedIdProviderName))
            {
                 WithArguments(trustedIdProviderName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Store account.
        /// </summary>
        public AzureDlsAccountTrustedProviderDeleteTask ResourceGroup(string resourceGroup = null)
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
