
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotMsteamsCreateTask : ExternalProcessTaskBase<AzureBotMsteamsCreateTask>
     {
        
        /// <summary>
        /// Create the Microsoft Teams Channel on a bot.
        /// </summary>
        public AzureBotMsteamsCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot msteams create");
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
        public AzureBotMsteamsCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// The calling web hook to use on Microsoft Teams.
        /// </summary>
        public AzureBotMsteamsCreateTask CallingWebHook(string callingWebHook = null)
        {
            WithArguments("--calling-web-hook");
            if (!string.IsNullOrEmpty(callingWebHook))
            {
                 WithArguments(callingWebHook);
            }

            return this;
        }

        /// <summary>
        /// Enable calling on Microsoft Teams.
        /// </summary>
        public AzureBotMsteamsCreateTask EnableCalling(string enableCalling = null)
        {
            WithArguments("--enable-calling");
            if (!string.IsNullOrEmpty(enableCalling))
            {
                 WithArguments(enableCalling);
            }

            return this;
        }
     }
}
