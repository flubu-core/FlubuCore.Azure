
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountLockTask : ExternalProcessTaskBase<AzureAccountLockTask>
     {
        
        /// <summary>
        /// Manage Azure subscription level locks.
        /// </summary>
        public AzureAccountLockTask()
        {
            WithArguments("az account lock");
        }

        protected override string Description { get; set; }
        
     }
}
