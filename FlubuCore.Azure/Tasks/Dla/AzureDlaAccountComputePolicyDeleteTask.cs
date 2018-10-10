
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountComputePolicyDeleteTask : ExternalProcessTaskBase<AzureDlaAccountComputePolicyDeleteTask>
     {
        
        /// <summary>
        /// Delete a compute policy in a Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountComputePolicyDeleteTask(string account = null ,  string computePolicyName = null)
        {
            WithArguments("az dla account compute-policy delete");
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
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountComputePolicyDeleteTask ResourceGroup(string resourceGroup = null)
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
