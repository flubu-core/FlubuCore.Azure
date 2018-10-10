
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountManagementGroupSubscriptionRemoveTask : ExternalProcessTaskBase<AzureAccountManagementGroupSubscriptionRemoveTask>
     {
        
        /// <summary>
        /// Remove an existing subscription from a management group.
        /// </summary>
        public AzureAccountManagementGroupSubscriptionRemoveTask(string name = null ,  string subscription = null)
        {
            WithArguments("az account management-group subscription remove");
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
