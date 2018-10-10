
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountCreateTask : ExternalProcessTaskBase<AzureAmsAccountCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Media Services account.
        /// </summary>
        public AzureAmsAccountCreateTask(string name = null ,  string resourceGroup = null ,  string storageAccount = null)
        {
            WithArguments("az ams account create");
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

WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAmsAccountCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureAmsAccountCreateTask Tags(string tags = null)
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
