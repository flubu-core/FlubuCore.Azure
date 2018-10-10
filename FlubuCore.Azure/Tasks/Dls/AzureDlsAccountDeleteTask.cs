
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountDeleteTask : ExternalProcessTaskBase<AzureDlsAccountDeleteTask>
     {
        
        /// <summary>
        /// Delete a Data Lake Store account.
        /// </summary>
        public AzureDlsAccountDeleteTask(string account = null)
        {
            WithArguments("az dls account delete");
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
        public AzureDlsAccountDeleteTask ResourceGroup(string resourceGroup = null)
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
