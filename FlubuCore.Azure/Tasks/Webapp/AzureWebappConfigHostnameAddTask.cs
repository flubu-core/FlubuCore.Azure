
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigHostnameAddTask : ExternalProcessTaskBase<AzureWebappConfigHostnameAddTask>
     {
        
        /// <summary>
        /// Bind a hostname to a web app.
        /// </summary>
        public AzureWebappConfigHostnameAddTask(string hostname = null ,  string resourceGroup = null ,  string webappName = null)
        {
            WithArguments("az webapp config hostname add");
WithArguments("--hostname");
            if (!string.IsNullOrEmpty(hostname))
            {
                 WithArguments(hostname);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--webapp-name");
            if (!string.IsNullOrEmpty(webappName))
            {
                 WithArguments(webappName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigHostnameAddTask Slot(string slot = null)
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
