
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotAuthsettingTask : ExternalProcessTaskBase<AzureBotAuthsettingTask>
     {
        
        /// <summary>
        /// Manage OAuth connection settings on a bot.
        /// </summary>
        public AzureBotAuthsettingTask()
        {
            WithArguments("az bot authsetting");
        }

        protected override string Description { get; set; }
        
     }
}
