
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSmsDeleteTask : ExternalProcessTaskBase<AzureBotSmsDeleteTask>
     {
        
        /// <summary>
        /// Delete the SMS Channel on a bot.
        /// </summary>
        public AzureBotSmsDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot sms delete");
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
