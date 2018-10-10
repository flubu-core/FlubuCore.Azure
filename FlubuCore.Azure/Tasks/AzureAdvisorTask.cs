
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAdvisorTask : ExternalProcessTaskBase<AzureAdvisorTask>
     {
        
        /// <summary>
        /// Manage Azure Advisor.
        /// </summary>
        public AzureAdvisorTask()
        {
            WithArguments("az advisor");
        }

        protected override string Description { get; set; }
        
     }
}
