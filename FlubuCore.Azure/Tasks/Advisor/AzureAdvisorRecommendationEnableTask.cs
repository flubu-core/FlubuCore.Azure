
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Advisor
{
     public partial class AzureAdvisorRecommendationEnableTask : ExternalProcessTaskBase<AzureAdvisorRecommendationEnableTask>
     {
        
        /// <summary>
        /// Enable Azure Advisor recommendations.
        /// </summary>
        public AzureAdvisorRecommendationEnableTask()
        {
            WithArguments("az advisor recommendation enable");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureAdvisorRecommendationEnableTask Ids(string ids = null)
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
        public AzureAdvisorRecommendationEnableTask Name(string name = null)
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
        public AzureAdvisorRecommendationEnableTask ResourceGroup(string resourceGroup = null)
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
