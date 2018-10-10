
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotDownloadTask : ExternalProcessTaskBase<AzureBotDownloadTask>
     {
        
        /// <summary>
        /// Download an existing bot.
        /// </summary>
        public AzureBotDownloadTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot download");
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
        /// The directory to download bot code to.
        /// </summary>
        public AzureBotDownloadTask SavePath(string savePath = null)
        {
            WithArguments("--save-path");
            if (!string.IsNullOrEmpty(savePath))
            {
                 WithArguments(savePath);
            }

            return this;
        }
     }
}
