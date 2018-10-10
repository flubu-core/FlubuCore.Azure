
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureGroupTask : ExternalProcessTaskBase<AzureGroupTask>
     {
        
        /// <summary>
        /// Manage resource groups and template deployments.
        /// </summary>
        public AzureGroupTask()
        {
            WithArguments("az group");
        }

        protected override string Description { get; set; }
        
     }
}
