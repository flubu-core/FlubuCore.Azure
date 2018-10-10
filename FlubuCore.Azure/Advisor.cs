
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Advisor;

namespace FlubuCore.Azure
{
    public class Advisor
    {
        
        
            public AzureAdvisorConfigurationTask AdvisorConfiguration()
            {
                return new AzureAdvisorConfigurationTask();
            }

            public AzureAdvisorConfigurationUpdateTask AdvisorConfigurationUpdate()
            {
                return new AzureAdvisorConfigurationUpdateTask();
            }

            public AzureAdvisorRecommendationTask AdvisorRecommendation()
            {
                return new AzureAdvisorRecommendationTask();
            }

            public AzureAdvisorRecommendationDisableTask AdvisorRecommendationDisable()
            {
                return new AzureAdvisorRecommendationDisableTask();
            }

            public AzureAdvisorRecommendationEnableTask AdvisorRecommendationEnable()
            {
                return new AzureAdvisorRecommendationEnableTask();
            }
        
    }
}

