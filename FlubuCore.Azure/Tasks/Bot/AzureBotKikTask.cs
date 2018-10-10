
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotKikTask : ExternalProcessTaskBase<AzureBotKikTask>
     {
        
        /// <summary>
        /// Manage the Kik Channel on a bot.
        /// </summary>
        public AzureBotKikTask()
        {
            WithArguments("az bot kik");
        }

        protected override string Description { get; set; }
        
     }
}
