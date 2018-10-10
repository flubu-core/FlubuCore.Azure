
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotMsteamsTask : ExternalProcessTaskBase<AzureBotMsteamsTask>
     {
        
        /// <summary>
        /// Manage the Microsoft Teams Channel on a bot.
        /// </summary>
        public AzureBotMsteamsTask()
        {
            WithArguments("az bot msteams");
        }

        protected override string Description { get; set; }
        
     }
}
