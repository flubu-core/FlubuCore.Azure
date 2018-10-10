
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Billing
{
     public partial class AzureBillingInvoiceTask : ExternalProcessTaskBase<AzureBillingInvoiceTask>
     {
        
        /// <summary>
        /// Get billing invoices for a subscription.
        /// </summary>
        public AzureBillingInvoiceTask()
        {
            WithArguments("az billing invoice");
        }

        protected override string Description { get; set; }
        
     }
}
