
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotFacebookTask : ExternalProcessTaskBase<AzureBotFacebookTask>
     {
        
        /// <summary>
        /// Manage the Facebook Channel on a bot.
        /// </summary>
        public AzureBotFacebookTask()
        {
            WithArguments("az bot facebook");
        }

        protected override string Description { get; set; }
        
     }
}
