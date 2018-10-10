
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cognitiveservices
{
     public partial class AzureCognitiveservicesAccountKeysRegenerateTask : ExternalProcessTaskBase<AzureCognitiveservicesAccountKeysRegenerateTask>
     {
        
        /// <summary>
        /// Regenerate the keys of an Azure Cognitive Services account.
        /// </summary>
        public AzureCognitiveservicesAccountKeysRegenerateTask(string keyName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cognitiveservices account keys regenerate");
WithArguments("--key-name");
            if (!string.IsNullOrEmpty(keyName))
            {
                 WithArguments(keyName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
