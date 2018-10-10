
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountManagementGroupSubscriptionAddTask : ExternalProcessTaskBase<AzureAccountManagementGroupSubscriptionAddTask>
     {
        
        /// <summary>
        /// Add a subscription to a management group.
        /// </summary>
        public AzureAccountManagementGroupSubscriptionAddTask(string name = null ,  string subscription = null)
        {
            WithArguments("az account management-group subscription add");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--subscription");
            if (!string.IsNullOrEmpty(subscription))
            {
                 WithArguments(subscription);
            }

        }

        protected override string Description { get; set; }
        
     }
}
