
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotDirectlineCreateTask : ExternalProcessTaskBase<AzureBotDirectlineCreateTask>
     {
        
        /// <summary>
        /// Create the DirectLine Channel on a bot with only v3 protocol enabled.
        /// </summary>
        public AzureBotDirectlineCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot directline create");
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
        public AzureBotDirectlineCreateTask AddDisabled(string addDisabled = null)
        {
            WithArguments("--add-disabled");
            if (!string.IsNullOrEmpty(addDisabled))
            {
                 WithArguments(addDisabled);
            }

            return this;
        }

        /// <summary>
        /// If true, v1 protocol will be disabled on the channel.
        /// </summary>
        public AzureBotDirectlineCreateTask Disablev1(string disablev1 = null)
        {
            WithArguments("--disablev1");
            if (!string.IsNullOrEmpty(disablev1))
            {
                 WithArguments(disablev1);
            }

            return this;
        }

        /// <summary>
        /// If true, v3 protocol will be disabled on the channel.
        /// </summary>
        public AzureBotDirectlineCreateTask Disablev3(string disablev3 = null)
        {
            WithArguments("--disablev3");
            if (!string.IsNullOrEmpty(disablev3))
            {
                 WithArguments(disablev3);
            }

            return this;
        }

        /// <summary>
        /// Name of the Directline channel site.
        /// </summary>
        public AzureBotDirectlineCreateTask SiteName(string siteName = null)
        {
            WithArguments("--site-name");
            if (!string.IsNullOrEmpty(siteName))
            {
                 WithArguments(siteName);
            }

            return this;
        }
     }
}
