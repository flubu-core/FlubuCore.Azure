
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotSkypeCreateTask : ExternalProcessTaskBase<AzureBotSkypeCreateTask>
     {
        
        /// <summary>
        /// Create the Skype Channel on a bot.
        /// </summary>
        public AzureBotSkypeCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot skype create");
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
        public AzureBotSkypeCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// The calling web hook to use on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask CallingWebHook(string callingWebHook = null)
        {
            WithArguments("--calling-web-hook");
            if (!string.IsNullOrEmpty(callingWebHook))
            {
                 WithArguments(callingWebHook);
            }

            return this;
        }

        /// <summary>
        /// Enable calling on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask EnableCalling(string enableCalling = null)
        {
            WithArguments("--enable-calling");
            if (!string.IsNullOrEmpty(enableCalling))
            {
                 WithArguments(enableCalling);
            }

            return this;
        }

        /// <summary>
        /// Enable groups on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask EnableGroups(string enableGroups = null)
        {
            WithArguments("--enable-groups");
            if (!string.IsNullOrEmpty(enableGroups))
            {
                 WithArguments(enableGroups);
            }

            return this;
        }

        /// <summary>
        /// Enable media cards on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask EnableMediaCards(string enableMediaCards = null)
        {
            WithArguments("--enable-media-cards");
            if (!string.IsNullOrEmpty(enableMediaCards))
            {
                 WithArguments(enableMediaCards);
            }

            return this;
        }

        /// <summary>
        /// Enable messaging on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask EnableMessaging(string enableMessaging = null)
        {
            WithArguments("--enable-messaging");
            if (!string.IsNullOrEmpty(enableMessaging))
            {
                 WithArguments(enableMessaging);
            }

            return this;
        }

        /// <summary>
        /// Enable screen sharing on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask EnableScreenSharing(string enableScreenSharing = null)
        {
            WithArguments("--enable-screen-sharing");
            if (!string.IsNullOrEmpty(enableScreenSharing))
            {
                 WithArguments(enableScreenSharing);
            }

            return this;
        }

        /// <summary>
        /// Enable video on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask EnableVideo(string enableVideo = null)
        {
            WithArguments("--enable-video");
            if (!string.IsNullOrEmpty(enableVideo))
            {
                 WithArguments(enableVideo);
            }

            return this;
        }

        /// <summary>
        /// Select groups mode on Skype.
        /// </summary>
        public AzureBotSkypeCreateTask GroupsMode(string groupsMode = null)
        {
            WithArguments("--groups-mode");
            if (!string.IsNullOrEmpty(groupsMode))
            {
                 WithArguments(groupsMode);
            }

            return this;
        }
     }
}
