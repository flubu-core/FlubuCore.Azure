
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountTrustedProviderUpdateTask : ExternalProcessTaskBase<AzureDlsAccountTrustedProviderUpdateTask>
     {
        
        /// <summary>
        /// Updates the specified trusted identity provider.
        /// </summary>
        public AzureDlsAccountTrustedProviderUpdateTask(string account = null ,  string trustedIdProviderName = null)
        {
            WithArguments("az dls account trusted-provider update");
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
        /// The URL of this trusted identity provider.
        /// </summary>
        public AzureDlsAccountTrustedProviderUpdateTask IdProvider(string idProvider = null)
        {
            WithArguments("--id-provider");
            if (!string.IsNullOrEmpty(idProvider))
            {
                 WithArguments(idProvider);
            }

            return this;
        }

        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Store account.
        /// </summary>
        public AzureDlsAccountTrustedProviderUpdateTask ResourceGroup(string resourceGroup = null)
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
