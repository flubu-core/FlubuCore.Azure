
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotDirectlineTask : ExternalProcessTaskBase<AzureBotDirectlineTask>
     {
        
        /// <summary>
        /// Manage the Directline Channel on a bot.
        /// </summary>
        public AzureBotDirectlineTask()
        {
            WithArguments("az bot directline");
        }

        protected override string Description { get; set; }
        
     }
}
