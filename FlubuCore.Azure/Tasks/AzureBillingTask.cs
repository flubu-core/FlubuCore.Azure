
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureBillingTask : ExternalProcessTaskBase<AzureBillingTask>
     {
        
        /// <summary>
        /// Manage Azure Billing.
        /// </summary>
        public AzureBillingTask()
        {
            WithArguments("az billing");
        }

        protected override string Description { get; set; }
        
     }
}
