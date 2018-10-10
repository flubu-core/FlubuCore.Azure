
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotTelegramTask : ExternalProcessTaskBase<AzureBotTelegramTask>
     {
        
        /// <summary>
        /// Manage the Telegram Channel on a bot.
        /// </summary>
        public AzureBotTelegramTask()
        {
            WithArguments("az bot telegram");
        }

        protected override string Description { get; set; }
        
     }
}
