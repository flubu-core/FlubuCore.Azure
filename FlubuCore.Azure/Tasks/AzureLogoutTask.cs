
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureLogoutTask : ExternalProcessTaskBase<AzureLogoutTask>
     {
        
        /// <summary>
        /// Log out to remove access to Azure subscriptions.
        /// </summary>
        public AzureLogoutTask()
        {
            WithArguments("az logout");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Account user, if missing, logout the current active account.
        /// </summary>
        public AzureLogoutTask Username(string username = null)
        {
            WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

            return this;
        }
     }
}
