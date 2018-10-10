
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridTopicKeyRegenerateTask : ExternalProcessTaskBase<AzureEventgridTopicKeyRegenerateTask>
     {
        
        /// <summary>
        /// Regenerate a shared access key of a topic.
        /// </summary>
        public AzureEventgridTopicKeyRegenerateTask(string keyName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az eventgrid topic key regenerate");
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
