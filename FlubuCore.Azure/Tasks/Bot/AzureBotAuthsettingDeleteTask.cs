
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotAuthsettingDeleteTask : ExternalProcessTaskBase<AzureBotAuthsettingDeleteTask>
     {
        
        /// <summary>
        /// Delete an OAuth connection setting on a bot.
        /// </summary>
        public AzureBotAuthsettingDeleteTask(string name = null ,  string resourceGroup = null ,  string settingName = null)
        {
            WithArguments("az bot authsetting delete");
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

WithArguments("--setting-name");
            if (!string.IsNullOrEmpty(settingName))
            {
                 WithArguments(settingName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
