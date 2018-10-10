
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAcsTask : ExternalProcessTaskBase<AzureAcsTask>
     {
        
        /// <summary>
        /// Manage Azure Container Services.
        /// </summary>
        public AzureAcsTask()
        {
            WithArguments("az acs");
        }

        protected override string Description { get; set; }
        
     }
}
