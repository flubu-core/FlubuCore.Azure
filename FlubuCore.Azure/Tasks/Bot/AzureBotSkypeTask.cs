
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSkypeTask : ExternalProcessTaskBase<AzureBotSkypeTask>
     {
        
        /// <summary>
        /// Manage the Skype Channel on a bot.
        /// </summary>
        public AzureBotSkypeTask()
        {
            WithArguments("az bot skype");
        }

        protected override string Description { get; set; }
        
     }
}
