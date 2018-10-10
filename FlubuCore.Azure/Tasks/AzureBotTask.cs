
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureBotTask : ExternalProcessTaskBase<AzureBotTask>
     {
        
        /// <summary>
        /// Manage Microsoft Bot Services.
        /// </summary>
        public AzureBotTask()
        {
            WithArguments("az bot");
        }

        protected override string Description { get; set; }
        
     }
}
