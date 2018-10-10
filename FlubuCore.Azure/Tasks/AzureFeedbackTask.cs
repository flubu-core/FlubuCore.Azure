
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureFeedbackTask : ExternalProcessTaskBase<AzureFeedbackTask>
     {
        
        /// <summary>
        /// Send feedback to the Azure CLI Team!
        /// </summary>
        public AzureFeedbackTask()
        {
            WithArguments("az feedback");
        }

        protected override string Description { get; set; }
        
     }
}
