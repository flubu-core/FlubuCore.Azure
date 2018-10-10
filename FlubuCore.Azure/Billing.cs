
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Billing;

namespace FlubuCore.Azure
{
    public class Billing
    {
        
        
            public AzureBillingEnrollmentAccountTask BillingEnrollmentAccount()
            {
                return new AzureBillingEnrollmentAccountTask();
            }

            public AzureBillingInvoiceTask BillingInvoice()
            {
                return new AzureBillingInvoiceTask();
            }

            public AzureBillingPeriodTask BillingPeriod()
            {
                return new AzureBillingPeriodTask();
            }
        
    }
}

