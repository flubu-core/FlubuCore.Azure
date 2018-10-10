
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountTrustedProviderCreateTask : ExternalProcessTaskBase<AzureDlsAccountTrustedProviderCreateTask>
     {
        
        /// <summary>
        /// Creates or updates the specified trusted identity provider.
        /// </summary>
        public AzureDlsAccountTrustedProviderCreateTask(string account = null ,  string idProvider = null ,  string trustedIdProviderName = null)
        {
            WithArguments("az dls account trusted-provider create");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--id-provider");
            if (!string.IsNullOrEmpty(idProvider))
            {
                 WithArguments(idProvider);
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
        public AzureDlsAccountTrustedProviderCreateTask ResourceGroup(string resourceGroup = null)
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
