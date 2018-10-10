
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Billing
{
     public partial class AzureBillingPeriodTask : ExternalProcessTaskBase<AzureBillingPeriodTask>
     {
        
        /// <summary>
        /// Get billing periods for a subscription.
        /// </summary>
        public AzureBillingPeriodTask()
        {
            WithArguments("az billing period");
        }

        protected override string Description { get; set; }
        
     }
}
