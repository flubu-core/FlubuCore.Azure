
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountSetTask : ExternalProcessTaskBase<AzureAccountSetTask>
     {
        
        /// <summary>
        /// Set a subscription to be the current active subscription.
        /// </summary>
        public AzureAccountSetTask(string subscription = null)
        {
            WithArguments("az account set");
WithArguments("--subscription");
            if (!string.IsNullOrEmpty(subscription))
            {
                 WithArguments(subscription);
            }

        }

        protected override string Description { get; set; }
        
     }
}
