
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotEmailTask : ExternalProcessTaskBase<AzureBotEmailTask>
     {
        
        /// <summary>
        /// Manage the email Channel on a bot.
        /// </summary>
        public AzureBotEmailTask()
        {
            WithArguments("az bot email");
        }

        protected override string Description { get; set; }
        
     }
}
