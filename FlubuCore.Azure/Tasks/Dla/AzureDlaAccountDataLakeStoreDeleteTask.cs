
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountDataLakeStoreDeleteTask : ExternalProcessTaskBase<AzureDlaAccountDataLakeStoreDeleteTask>
     {
        
        /// <summary>
        /// Updates the Data Lake Analytics account specified to remove the specified Data Lake Store account.
        /// </summary>
        public AzureDlaAccountDataLakeStoreDeleteTask(string account = null ,  string dataLakeStoreAccountName = null)
        {
            WithArguments("az dla account data-lake-store delete");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--data-lake-store-account-name");
            if (!string.IsNullOrEmpty(dataLakeStoreAccountName))
            {
                 WithArguments(dataLakeStoreAccountName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountDataLakeStoreDeleteTask ResourceGroup(string resourceGroup = null)
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
