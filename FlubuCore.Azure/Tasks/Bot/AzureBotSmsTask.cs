
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSmsTask : ExternalProcessTaskBase<AzureBotSmsTask>
     {
        
        /// <summary>
        /// Manage the SMS Channel on a bot.
        /// </summary>
        public AzureBotSmsTask()
        {
            WithArguments("az bot sms");
        }

        protected override string Description { get; set; }
        
     }
}
