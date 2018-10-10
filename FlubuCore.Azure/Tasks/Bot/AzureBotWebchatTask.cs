
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotWebchatTask : ExternalProcessTaskBase<AzureBotWebchatTask>
     {
        
        /// <summary>
        /// Manage the Webchat Channel on a bot.
        /// </summary>
        public AzureBotWebchatTask()
        {
            WithArguments("az bot webchat");
        }

        protected override string Description { get; set; }
        
     }
}
