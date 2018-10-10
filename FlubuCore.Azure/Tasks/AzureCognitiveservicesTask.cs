
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureCognitiveservicesTask : ExternalProcessTaskBase<AzureCognitiveservicesTask>
     {
        
        /// <summary>
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        public AzureCognitiveservicesTask()
        {
            WithArguments("az cognitiveservices");
        }

        protected override string Description { get; set; }
        
     }
}
