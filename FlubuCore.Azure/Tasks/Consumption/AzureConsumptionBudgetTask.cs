
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionBudgetTask : ExternalProcessTaskBase<AzureConsumptionBudgetTask>
     {
        
        /// <summary>
        /// Manage budgets for an Azure subscription.
        /// </summary>
        public AzureConsumptionBudgetTask()
        {
            WithArguments("az consumption budget");
        }

        protected override string Description { get; set; }
        
     }
}
