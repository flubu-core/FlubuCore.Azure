
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Billing
{
     public partial class AzureBillingEnrollmentAccountTask : ExternalProcessTaskBase<AzureBillingEnrollmentAccountTask>
     {
        
        /// <summary>
        /// Get enrollment accounts.
        /// </summary>
        public AzureBillingEnrollmentAccountTask()
        {
            WithArguments("az billing enrollment-account");
        }

        protected override string Description { get; set; }
        
     }
}
