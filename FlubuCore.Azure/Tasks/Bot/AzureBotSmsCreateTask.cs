
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSmsCreateTask : ExternalProcessTaskBase<AzureBotSmsCreateTask>
     {
        
        /// <summary>
        /// Create the SMS Channel on a bot.
        /// </summary>
        public AzureBotSmsCreateTask(string accountSid = null ,  string authToken = null ,  string name = null ,  string phone = null ,  string resourceGroup = null)
        {
            WithArguments("az bot sms create");
WithArguments("--account-sid");
            if (!string.IsNullOrEmpty(accountSid))
            {
                 WithArguments(accountSid);
            }

WithArguments("--auth-token");
            if (!string.IsNullOrEmpty(authToken))
            {
                 WithArguments(authToken);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--phone");
            if (!string.IsNullOrEmpty(phone))
            {
                 WithArguments(phone);
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
        public AzureBotSmsCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// Whether or not the Twilio account has been validated for use with the bot.
        /// </summary>
        public AzureBotSmsCreateTask IsValidated(string isValidated = null)
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
