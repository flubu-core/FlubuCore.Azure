
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigAppsettingsSetTask : ExternalProcessTaskBase<AzureWebappConfigAppsettingsSetTask>
     {
        
        /// <summary>
        /// Set a web app's settings.
        /// </summary>
        public AzureWebappConfigAppsettingsSetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config appsettings set");
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
        /// Space-separated appsettings in a format of <name>=<value>.
        /// </summary>
        public AzureWebappConfigAppsettingsSetTask Settings(string settings = null)
        {
            WithArguments("--settings");
            if (!string.IsNullOrEmpty(settings))
            {
                 WithArguments(settings);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigAppsettingsSetTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Space-separated slot appsettings in a format of <name>=<value>.
        /// </summary>
        public AzureWebappConfigAppsettingsSetTask SlotSettings(string slotSettings = null)
        {
            WithArguments("--slot-settings");
            if (!string.IsNullOrEmpty(slotSettings))
            {
                 WithArguments(slotSettings);
            }

            return this;
        }
     }
}
