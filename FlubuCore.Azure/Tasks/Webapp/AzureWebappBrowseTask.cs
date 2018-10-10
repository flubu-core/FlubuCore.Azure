
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappBrowseTask : ExternalProcessTaskBase<AzureWebappBrowseTask>
     {
        
        /// <summary>
        /// Open a web app in a browser.
        /// </summary>
        public AzureWebappBrowseTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp browse");
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
        /// Enable viewing the log stream immediately after launching the web app.
        /// </summary>
        public AzureWebappBrowseTask Logs(string logs = null)
        {
            WithArguments("--logs");
            if (!string.IsNullOrEmpty(logs))
            {
                 WithArguments(logs);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappBrowseTask Slot(string slot = null)
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
