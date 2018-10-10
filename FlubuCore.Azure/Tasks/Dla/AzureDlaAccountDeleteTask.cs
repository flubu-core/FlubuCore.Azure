
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountDeleteTask : ExternalProcessTaskBase<AzureDlaAccountDeleteTask>
     {
        
        /// <summary>
        /// Delete a Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountDeleteTask(string account = null)
        {
            WithArguments("az dla account delete");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountDeleteTask ResourceGroup(string resourceGroup = null)
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
