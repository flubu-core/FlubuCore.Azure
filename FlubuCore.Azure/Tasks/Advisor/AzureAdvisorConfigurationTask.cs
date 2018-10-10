
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Advisor
{
     public partial class AzureAdvisorConfigurationTask : ExternalProcessTaskBase<AzureAdvisorConfigurationTask>
     {
        
        /// <summary>
        /// Manage Azure Advisor configuration.
        /// </summary>
        public AzureAdvisorConfigurationTask()
        {
            WithArguments("az advisor configuration");
        }

        protected override string Description { get; set; }
        
     }
}
