
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionMarketplaceTask : ExternalProcessTaskBase<AzureConsumptionMarketplaceTask>
     {
        
        /// <summary>
        /// Inspect the marketplace usage data of an Azure subscription within a billing period.
        /// </summary>
        public AzureConsumptionMarketplaceTask()
        {
            WithArguments("az consumption marketplace");
        }

        protected override string Description { get; set; }
        
     }
}
