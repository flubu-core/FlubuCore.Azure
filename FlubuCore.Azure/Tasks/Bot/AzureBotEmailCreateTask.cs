
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotEmailCreateTask : ExternalProcessTaskBase<AzureBotEmailCreateTask>
     {
        
        /// <summary>
        /// Create the Email Channel on a bot.
        /// </summary>
        public AzureBotEmailCreateTask(string emailAddress = null ,  string name = null ,  string password = null ,  string resourceGroup = null)
        {
            WithArguments("az bot email create");
WithArguments("--email-address");
            if (!string.IsNullOrEmpty(emailAddress))
            {
                 WithArguments(emailAddress);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
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
        public AzureBotEmailCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }
     }
}
