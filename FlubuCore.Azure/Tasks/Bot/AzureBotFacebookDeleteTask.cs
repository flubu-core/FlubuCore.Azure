
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotFacebookDeleteTask : ExternalProcessTaskBase<AzureBotFacebookDeleteTask>
     {
        
        /// <summary>
        /// Delete the Facebook Channel on a bot.
        /// </summary>
        public AzureBotFacebookDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot facebook delete");
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
