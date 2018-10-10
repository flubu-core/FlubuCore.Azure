
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cognitiveservices
{
     public partial class AzureCognitiveservicesAccountUpdateTask : ExternalProcessTaskBase<AzureCognitiveservicesAccountUpdateTask>
     {
        
        /// <summary>
        /// Update the properties of an Azure Cognitive Services account.
        /// </summary>
        public AzureCognitiveservicesAccountUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cognitiveservices account update");
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
        
        /// <summary>
        /// The Sku of cognitive services account.
        /// </summary>
        public AzureCognitiveservicesAccountUpdateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureCognitiveservicesAccountUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
