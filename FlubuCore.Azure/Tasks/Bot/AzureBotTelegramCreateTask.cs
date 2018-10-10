
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotTelegramCreateTask : ExternalProcessTaskBase<AzureBotTelegramCreateTask>
     {
        
        /// <summary>
        /// Create the Telegram Channel on a bot.
        /// </summary>
        public AzureBotTelegramCreateTask(string accessToken = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot telegram create");
WithArguments("--access-token");
            if (!string.IsNullOrEmpty(accessToken))
            {
                 WithArguments(accessToken);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add the channel in a disabled state.
        /// </summary>
        public AzureBotTelegramCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// Whether or not the Telegram account has been validated for use with the bot.
        /// </summary>
        public AzureBotTelegramCreateTask IsValidated(string isValidated = null)
        {
            WithArguments("--is-validated");
            if (!string.IsNullOrEmpty(isValidated))
            {
                 WithArguments(isValidated);
            }

            return this;
        }
     }
}
