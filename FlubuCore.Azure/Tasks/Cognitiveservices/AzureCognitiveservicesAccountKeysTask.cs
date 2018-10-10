
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cognitiveservices
{
     public partial class AzureCognitiveservicesAccountKeysTask : ExternalProcessTaskBase<AzureCognitiveservicesAccountKeysTask>
     {
        
        /// <summary>
        /// Manage the keys of an Azure Cognitive Services account.
        /// </summary>
        public AzureCognitiveservicesAccountKeysTask()
        {
            WithArguments("az cognitiveservices account keys");
        }

        protected override string Description { get; set; }
        
     }
}
