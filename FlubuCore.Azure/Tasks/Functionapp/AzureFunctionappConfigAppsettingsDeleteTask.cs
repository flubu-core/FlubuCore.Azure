
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigAppsettingsDeleteTask : ExternalProcessTaskBase<AzureFunctionappConfigAppsettingsDeleteTask>
     {
        
        /// <summary>
        /// Delete a function app's settings.
        /// </summary>
        public AzureFunctionappConfigAppsettingsDeleteTask(string name = null ,  string resourceGroup = null ,  string settingNames = null)
        {
            WithArguments("az functionapp config appsettings delete");
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

WithArguments("--setting-names");
            if (!string.IsNullOrEmpty(settingNames))
            {
                 WithArguments(settingNames);
            }

        }

        protected override string Description { get; set; }
        
     }
}
