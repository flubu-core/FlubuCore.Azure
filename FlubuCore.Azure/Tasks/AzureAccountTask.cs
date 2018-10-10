
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAccountTask : ExternalProcessTaskBase<AzureAccountTask>
     {
        
        /// <summary>
        /// Manage Azure subscription information.
        /// </summary>
        public AzureAccountTask()
        {
            WithArguments("az account");
        }

        protected override string Description { get; set; }
        
     }
}
