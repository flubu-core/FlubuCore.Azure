
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountManagementGroupSubscriptionTask : ExternalProcessTaskBase<AzureAccountManagementGroupSubscriptionTask>
     {
        
        /// <summary>
        /// Subscription operations for Management Groups.
        /// </summary>
        public AzureAccountManagementGroupSubscriptionTask()
        {
            WithArguments("az account management-group subscription");
        }

        protected override string Description { get; set; }
        
     }
}
