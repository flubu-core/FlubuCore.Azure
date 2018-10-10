
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountDataLakeStoreAddTask : ExternalProcessTaskBase<AzureDlaAccountDataLakeStoreAddTask>
     {
        
        /// <summary>
        /// Updates the specified Data Lake Analytics account to include the additional Data Lake Store account.
        /// </summary>
        public AzureDlaAccountDataLakeStoreAddTask(string account = null ,  string dataLakeStoreAccountName = null)
        {
            WithArguments("az dla account data-lake-store add");
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
        public AzureDlaAccountDataLakeStoreAddTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The optional suffix for the Data Lake Store account.
        /// </summary>
        public AzureDlaAccountDataLakeStoreAddTask Suffix(string suffix = null)
        {
            WithArguments("--suffix");
            if (!string.IsNullOrEmpty(suffix))
            {
                 WithArguments(suffix);
            }

            return this;
        }
     }
}
