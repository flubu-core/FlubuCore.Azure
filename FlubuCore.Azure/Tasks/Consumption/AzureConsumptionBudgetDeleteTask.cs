
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionBudgetDeleteTask : ExternalProcessTaskBase<AzureConsumptionBudgetDeleteTask>
     {
        
        /// <summary>
        /// Delete a budget for an Azure subscription.
        /// </summary>
        public AzureConsumptionBudgetDeleteTask(string budgetName = null)
        {
            WithArguments("az consumption budget delete");
WithArguments("--budget-name");
            if (!string.IsNullOrEmpty(budgetName))
            {
                 WithArguments(budgetName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureConsumptionBudgetDeleteTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
