
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Advisor
{
     public partial class AzureAdvisorRecommendationTask : ExternalProcessTaskBase<AzureAdvisorRecommendationTask>
     {
        
        /// <summary>
        /// Review Azure Advisor recommendations.
        /// </summary>
        public AzureAdvisorRecommendationTask()
        {
            WithArguments("az advisor recommendation");
        }

        protected override string Description { get; set; }
        
     }
}
