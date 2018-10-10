
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotFacebookCreateTask : ExternalProcessTaskBase<AzureBotFacebookCreateTask>
     {
        
        /// <summary>
        /// Create the Facebook Channel on a bot.
        /// </summary>
        public AzureBotFacebookCreateTask(string appid = null ,  string name = null ,  string pageId = null ,  string resourceGroup = null ,  string secret = null ,  string token = null)
        {
            WithArguments("az bot facebook create");
WithArguments("--appid");
            if (!string.IsNullOrEmpty(appid))
            {
                 WithArguments(appid);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--page-id");
            if (!string.IsNullOrEmpty(pageId))
            {
                 WithArguments(pageId);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--secret");
            if (!string.IsNullOrEmpty(secret))
            {
                 WithArguments(secret);
            }

WithArguments("--token");
            if (!string.IsNullOrEmpty(token))
            {
                 WithArguments(token);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add the channel in a disabled state.
        /// </summary>
        public AzureBotFacebookCreateTask AddDisabled(string addDisabled = null)
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
