
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigAppsettingsSetTask : ExternalProcessTaskBase<AzureFunctionappConfigAppsettingsSetTask>
     {
        
        /// <summary>
        /// Update a function app's settings.
        /// </summary>
        public AzureFunctionappConfigAppsettingsSetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config appsettings set");
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
        /// Space-separated app settings in a format of <name>=<value>.
        /// </summary>
        public AzureFunctionappConfigAppsettingsSetTask Settings(string settings = null)
        {
            WithArguments("--settings");
            if (!string.IsNullOrEmpty(settings))
            {
                 WithArguments(settings);
            }

            return this;
        }

        /// <summary>
        /// Space-separated slot app settings in a format of <name>=<value>.
        /// </summary>
        public AzureFunctionappConfigAppsettingsSetTask SlotSettings(string slotSettings = null)
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
