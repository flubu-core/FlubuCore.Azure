
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigHostnameAddTask : ExternalProcessTaskBase<AzureFunctionappConfigHostnameAddTask>
     {
        
        /// <summary>
        /// Bind a hostname to a function app.
        /// </summary>
        public AzureFunctionappConfigHostnameAddTask(string hostname = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config hostname add");
WithArguments("--hostname");
            if (!string.IsNullOrEmpty(hostname))
            {
                 WithArguments(hostname);
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
        
     }
}
