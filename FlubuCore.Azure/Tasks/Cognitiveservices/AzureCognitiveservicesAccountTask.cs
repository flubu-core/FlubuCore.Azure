
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cognitiveservices
{
     public partial class AzureCognitiveservicesAccountTask : ExternalProcessTaskBase<AzureCognitiveservicesAccountTask>
     {
        
        /// <summary>
        /// Manage Azure Cognitive Services accounts.
        /// </summary>
        public AzureCognitiveservicesAccountTask()
        {
            WithArguments("az cognitiveservices account");
        }

        protected override string Description { get; set; }
        
     }
}
