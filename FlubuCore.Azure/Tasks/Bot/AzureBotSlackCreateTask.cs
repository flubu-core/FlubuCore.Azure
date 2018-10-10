
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSlackCreateTask : ExternalProcessTaskBase<AzureBotSlackCreateTask>
     {
        
        /// <summary>
        /// Create the Slack Channel on a bot.
        /// </summary>
        public AzureBotSlackCreateTask(string clientId = null ,  string clientSecret = null ,  string name = null ,  string resourceGroup = null ,  string verificationToken = null)
        {
            WithArguments("az bot slack create");
WithArguments("--client-id");
            if (!string.IsNullOrEmpty(clientId))
            {
                 WithArguments(clientId);
            }

WithArguments("--client-secret");
            if (!string.IsNullOrEmpty(clientSecret))
            {
                 WithArguments(clientSecret);
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

WithArguments("--verification-token");
            if (!string.IsNullOrEmpty(verificationToken))
            {
                 WithArguments(verificationToken);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add the channel in a disabled state.
        /// </summary>
        public AzureBotSlackCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// The landing page url to redirect to after login.
        /// </summary>
        public AzureBotSlackCreateTask LandingPageUrl(string landingPageUrl = null)
        {
            WithArguments("--landing-page-url");
            if (!string.IsNullOrEmpty(landingPageUrl))
            {
                 WithArguments(landingPageUrl);
            }

            return this;
        }
     }
}
