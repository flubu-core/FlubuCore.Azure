
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotMsteamsDeleteTask : ExternalProcessTaskBase<AzureBotMsteamsDeleteTask>
     {
        
        /// <summary>
        /// Delete the Microsoft Teams Channel on a bot.
        /// </summary>
        public AzureBotMsteamsDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot msteams delete");
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
