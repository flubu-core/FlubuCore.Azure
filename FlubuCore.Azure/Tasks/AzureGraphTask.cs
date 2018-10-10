
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureGraphTask : ExternalProcessTaskBase<AzureGraphTask>
     {
        
        /// <summary>
        /// Query the resources managed by Azure Resource Manager.
        /// </summary>
        public AzureGraphTask()
        {
            WithArguments("az graph");
        }

        protected override string Description { get; set; }
        
     }
}
