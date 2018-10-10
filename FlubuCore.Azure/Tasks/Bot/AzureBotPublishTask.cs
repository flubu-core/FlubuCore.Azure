
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotPublishTask : ExternalProcessTaskBase<AzureBotPublishTask>
     {
        
        /// <summary>
        /// Publish to a bot's associated app service.
        /// </summary>
        public AzureBotPublishTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot publish");
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
        /// The directory to upload bot code from.
        /// </summary>
        public AzureBotPublishTask CodeDir(string codeDir = null)
        {
            WithArguments("--code-dir");
            if (!string.IsNullOrEmpty(codeDir))
            {
                 WithArguments(codeDir);
            }

            return this;
        }
     }
}
