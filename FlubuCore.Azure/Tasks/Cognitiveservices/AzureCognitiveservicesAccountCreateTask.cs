
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cognitiveservices
{
     public partial class AzureCognitiveservicesAccountCreateTask : ExternalProcessTaskBase<AzureCognitiveservicesAccountCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Cognitive Services account.
        /// </summary>
        public AzureCognitiveservicesAccountCreateTask(string kind = null ,  string location = null ,  string name = null ,  string resourceGroup = null ,  string sku = null)
        {
            WithArguments("az cognitiveservices account create");
WithArguments("--kind");
            if (!string.IsNullOrEmpty(kind))
            {
                 WithArguments(kind);
            }

WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
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

WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Api properties in JSON format or a=b c=d format. Some cognitive services (i.e. QnA Maker) require extra api properties to create the account.
        /// </summary>
        public AzureCognitiveservicesAccountCreateTask ApiProperties(string apiProperties = null)
        {
            WithArguments("--api-properties");
            if (!string.IsNullOrEmpty(apiProperties))
            {
                 WithArguments(apiProperties);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureCognitiveservicesAccountCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for terms confirmation.
        /// </summary>
        public AzureCognitiveservicesAccountCreateTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
