
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotDirectlineDeleteTask : ExternalProcessTaskBase<AzureBotDirectlineDeleteTask>
     {
        
        /// <summary>
        /// Delete the Directline Channel on a bot.
        /// </summary>
        public AzureBotDirectlineDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot directline delete");
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
