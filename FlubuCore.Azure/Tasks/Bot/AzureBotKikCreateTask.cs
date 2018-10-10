
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotKikCreateTask : ExternalProcessTaskBase<AzureBotKikCreateTask>
     {
        
        /// <summary>
        /// Create the Kik Channel on a bot.
        /// </summary>
        public AzureBotKikCreateTask(string key = null ,  string name = null ,  string resourceGroup = null ,  string userName = null)
        {
            WithArguments("az bot kik create");
WithArguments("--key");
            if (!string.IsNullOrEmpty(key))
            {
                 WithArguments(key);
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

WithArguments("--user-name");
            if (!string.IsNullOrEmpty(userName))
            {
                 WithArguments(userName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add the channel in a disabled state.
        /// </summary>
        public AzureBotKikCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// Whether or not the Kik account has been validated for use with the bot.
        /// </summary>
        public AzureBotKikCreateTask IsValidated(string isValidated = null)
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
