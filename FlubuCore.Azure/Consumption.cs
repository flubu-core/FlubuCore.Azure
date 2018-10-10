
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Consumption;

namespace FlubuCore.Azure
{
    public class Consumption
    {
        
        
            public AzureConsumptionBudgetTask ConsumptionBudget()
            {
                return new AzureConsumptionBudgetTask();
            }

            public AzureConsumptionBudgetCreateTask ConsumptionBudgetCreate(string amount ,  string budgetName ,  string category ,  string endDate ,  string startDate ,  string timeGrain)
            {
                return new AzureConsumptionBudgetCreateTask(amount,  budgetName,  category,  endDate,  startDate,  timeGrain);
            }

            public AzureConsumptionBudgetDeleteTask ConsumptionBudgetDelete(string budgetName)
            {
                return new AzureConsumptionBudgetDeleteTask(budgetName);
            }

            public AzureConsumptionMarketplaceTask ConsumptionMarketplace()
            {
                return new AzureConsumptionMarketplaceTask();
            }

            public AzureConsumptionPricesheetTask ConsumptionPricesheet()
            {
                return new AzureConsumptionPricesheetTask();
            }

            public AzureConsumptionReservationTask ConsumptionReservation()
            {
                return new AzureConsumptionReservationTask();
            }

            public AzureConsumptionUsageTask ConsumptionUsage()
            {
                return new AzureConsumptionUsageTask();
            }

            public AzureConsumptionReservationDetailTask ConsumptionReservationDetail()
            {
                return new AzureConsumptionReservationDetailTask();
            }

            public AzureConsumptionReservationSummaryTask ConsumptionReservationSummary()
            {
                return new AzureConsumptionReservationSummaryTask();
            }
        
    }
}

