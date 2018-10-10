
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigConnectionStringDeleteTask : ExternalProcessTaskBase<AzureWebappConfigConnectionStringDeleteTask>
     {
        
        /// <summary>
        /// Delete a web app's connection strings.
        /// </summary>
        public AzureWebappConfigConnectionStringDeleteTask(string name = null ,  string resourceGroup = null ,  string settingNames = null)
        {
            WithArguments("az webapp config connection-string delete");
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
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigConnectionStringDeleteTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
