
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabEnvironmentTask : ExternalProcessTaskBase<AzureLabEnvironmentTask>
     {
        
        /// <summary>
        /// Manage environments for an Azure DevTest Lab.
        /// </summary>
        public AzureLabEnvironmentTask()
        {
            WithArguments("az lab environment");
        }

        protected override string Description { get; set; }
        
     }
}
