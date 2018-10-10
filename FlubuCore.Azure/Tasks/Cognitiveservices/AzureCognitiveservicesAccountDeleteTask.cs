
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cognitiveservices
{
     public partial class AzureCognitiveservicesAccountDeleteTask : ExternalProcessTaskBase<AzureCognitiveservicesAccountDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure Cognitive Services account.
        /// </summary>
        public AzureCognitiveservicesAccountDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cognitiveservices account delete");
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
