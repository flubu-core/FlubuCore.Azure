
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigConnectionStringSetTask : ExternalProcessTaskBase<AzureWebappConfigConnectionStringSetTask>
     {
        
        /// <summary>
        /// Update a web app's connection strings.
        /// </summary>
        public AzureWebappConfigConnectionStringSetTask(string connectionStringType = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config connection-string set");
WithArguments("--connection-string-type");
            if (!string.IsNullOrEmpty(connectionStringType))
            {
                 WithArguments(connectionStringType);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated connection-string in a format of <name>=<value>.
        /// </summary>
        public AzureWebappConfigConnectionStringSetTask Settings(string settings = null)
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
        public AzureWebappConfigConnectionStringSetTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Space-separated slot connection-string in a format of <name>=<value>.
        /// </summary>
        public AzureWebappConfigConnectionStringSetTask SlotSettings(string slotSettings = null)
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
