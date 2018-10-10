
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSkypeDeleteTask : ExternalProcessTaskBase<AzureBotSkypeDeleteTask>
     {
        
        /// <summary>
        /// Delete the Skype Channel on a bot.
        /// </summary>
        public AzureBotSkypeDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot skype delete");
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
