
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionBudgetCreateTask : ExternalProcessTaskBase<AzureConsumptionBudgetCreateTask>
     {
        
        /// <summary>
        /// Create a budget for an Azure subscription.
        /// </summary>
        public AzureConsumptionBudgetCreateTask(string amount = null ,  string budgetName = null ,  string category = null ,  string endDate = null ,  string startDate = null ,  string timeGrain = null)
        {
            WithArguments("az consumption budget create");
WithArguments("--amount");
            if (!string.IsNullOrEmpty(amount))
            {
                 WithArguments(amount);
            }

WithArguments("--budget-name");
            if (!string.IsNullOrEmpty(budgetName))
            {
                 WithArguments(budgetName);
            }

WithArguments("--category");
            if (!string.IsNullOrEmpty(category))
            {
                 WithArguments(category);
            }

WithArguments("--end-date");
            if (!string.IsNullOrEmpty(endDate))
            {
                 WithArguments(endDate);
            }

WithArguments("--start-date");
            if (!string.IsNullOrEmpty(startDate))
            {
                 WithArguments(startDate);
            }

WithArguments("--time-grain");
            if (!string.IsNullOrEmpty(timeGrain))
            {
                 WithArguments(timeGrain);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of meters to filter on. Required if category is usage.
        /// </summary>
        public AzureConsumptionBudgetCreateTask MeterFilter(string meterFilter = null)
        {
            WithArguments("--meter-filter");
            if (!string.IsNullOrEmpty(meterFilter))
            {
                 WithArguments(meterFilter);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of resource instances to filter on.
        /// </summary>
        public AzureConsumptionBudgetCreateTask ResourceFilter(string resourceFilter = null)
        {
            WithArguments("--resource-filter");
            if (!string.IsNullOrEmpty(resourceFilter))
            {
                 WithArguments(resourceFilter);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureConsumptionBudgetCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of resource groups to filter on.
        /// </summary>
        public AzureConsumptionBudgetCreateTask ResourceGroupFilter(string resourceGroupFilter = null)
        {
            WithArguments("--resource-group-filter");
            if (!string.IsNullOrEmpty(resourceGroupFilter))
            {
                 WithArguments(resourceGroupFilter);
            }

            return this;
        }
     }
}
