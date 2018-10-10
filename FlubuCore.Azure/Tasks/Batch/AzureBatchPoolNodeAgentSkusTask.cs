
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolNodeAgentSkusTask : ExternalProcessTaskBase<AzureBatchPoolNodeAgentSkusTask>
     {
        
        /// <summary>
        /// Retrieve node agent SKUs of Batch pools using a Virtual Machine Configuration.
        /// </summary>
        public AzureBatchPoolNodeAgentSkusTask()
        {
            WithArguments("az batch pool node-agent-skus");
        }

        protected override string Description { get; set; }
        
     }
}
