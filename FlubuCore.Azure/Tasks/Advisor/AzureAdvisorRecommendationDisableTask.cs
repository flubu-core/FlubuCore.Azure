
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Advisor
{
     public partial class AzureAdvisorRecommendationDisableTask : ExternalProcessTaskBase<AzureAdvisorRecommendationDisableTask>
     {
        
        /// <summary>
        /// Disable Azure Advisor recommendations.
        /// </summary>
        public AzureAdvisorRecommendationDisableTask()
        {
            WithArguments("az advisor recommendation disable");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Number of days to disable. If not specified, the recommendation is disabled forever.
        /// </summary>
        public AzureAdvisorRecommendationDisableTask Days(string days = null)
        {
            WithArguments("--days");
            if (!string.IsNullOrEmpty(days))
            {
                 WithArguments(days);
            }

            return this;
        }

        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureAdvisorRecommendationDisableTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        /// <summary>
        /// The name of the recommendation as output by the list command.
        /// </summary>
        public AzureAdvisorRecommendationDisableTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAdvisorRecommendationDisableTask ResourceGroup(string resourceGroup = null)
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
