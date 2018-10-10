
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSlackTask : ExternalProcessTaskBase<AzureBotSlackTask>
     {
        
        /// <summary>
        /// Manage the Slack Channel on a bot.
        /// </summary>
        public AzureBotSlackTask()
        {
            WithArguments("az bot slack");
        }

        protected override string Description { get; set; }
        
     }
}
