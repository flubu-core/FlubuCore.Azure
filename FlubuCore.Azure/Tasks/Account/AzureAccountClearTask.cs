
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountClearTask : ExternalProcessTaskBase<AzureAccountClearTask>
     {
        
        /// <summary>
        /// Clear all subscriptions from the CLI's local cache.
        /// </summary>
        public AzureAccountClearTask()
        {
            WithArguments("az account clear");
        }

        protected override string Description { get; set; }
        
     }
}
