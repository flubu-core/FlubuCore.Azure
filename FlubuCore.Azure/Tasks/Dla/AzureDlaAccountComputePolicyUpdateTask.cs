
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountComputePolicyUpdateTask : ExternalProcessTaskBase<AzureDlaAccountComputePolicyUpdateTask>
     {
        
        /// <summary>
        /// Update a compute policy in the Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountComputePolicyUpdateTask(string account = null ,  string computePolicyName = null)
        {
            WithArguments("az dla account compute-policy update");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--compute-policy-name");
            if (!string.IsNullOrEmpty(computePolicyName))
            {
                 WithArguments(computePolicyName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.
        /// </summary>
        public AzureDlaAccountComputePolicyUpdateTask MaxDopPerJob(string maxDopPerJob = null)
        {
            WithArguments("--max-dop-per-job");
            if (!string.IsNullOrEmpty(maxDopPerJob))
            {
                 WithArguments(maxDopPerJob);
            }

            return this;
        }

        /// <summary>
        /// The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.
        /// </summary>
        public AzureDlaAccountComputePolicyUpdateTask MinPriorityPerJob(string minPriorityPerJob = null)
        {
            WithArguments("--min-priority-per-job");
            if (!string.IsNullOrEmpty(minPriorityPerJob))
            {
                 WithArguments(minPriorityPerJob);
            }

            return this;
        }

        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountComputePolicyUpdateTask ResourceGroup(string resourceGroup = null)
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
