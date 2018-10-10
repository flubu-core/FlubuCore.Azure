
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotEmailDeleteTask : ExternalProcessTaskBase<AzureBotEmailDeleteTask>
     {
        
        /// <summary>
        /// Delete the email Channel on a bot.
        /// </summary>
        public AzureBotEmailDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot email delete");
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
