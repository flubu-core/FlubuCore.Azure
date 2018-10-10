
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountCreateTask : ExternalProcessTaskBase<AzureDlaAccountCreateTask>
     {
        
        /// <summary>
        /// Create a Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountCreateTask(string account = null ,  string defaultDataLakeStore = null)
        {
            WithArguments("az dla account create");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--default-data-lake-store");
            if (!string.IsNullOrEmpty(defaultDataLakeStore))
            {
                 WithArguments(defaultDataLakeStore);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureDlaAccountCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The maximum degree of parallelism for this account.
        /// </summary>
        public AzureDlaAccountCreateTask MaxDegreeOfParallelism(string maxDegreeOfParallelism = null)
        {
            WithArguments("--max-degree-of-parallelism");
            if (!string.IsNullOrEmpty(maxDegreeOfParallelism))
            {
                 WithArguments(maxDegreeOfParallelism);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of concurrent jobs for this account.
        /// </summary>
        public AzureDlaAccountCreateTask MaxJobCount(string maxJobCount = null)
        {
            WithArguments("--max-job-count");
            if (!string.IsNullOrEmpty(maxJobCount))
            {
                 WithArguments(maxJobCount);
            }

            return this;
        }

        /// <summary>
        /// The number of days to retain job metadata.
        /// </summary>
        public AzureDlaAccountCreateTask QueryStoreRetention(string queryStoreRetention = null)
        {
            WithArguments("--query-store-retention");
            if (!string.IsNullOrEmpty(queryStoreRetention))
            {
                 WithArguments(queryStoreRetention);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureDlaAccountCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureDlaAccountCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The desired commitment tier for this account to use.
        /// </summary>
        public AzureDlaAccountCreateTask Tier(string tier = null)
        {
            WithArguments("--tier");
            if (!string.IsNullOrEmpty(tier))
            {
                 WithArguments(tier);
            }

            return this;
        }
     }
}
