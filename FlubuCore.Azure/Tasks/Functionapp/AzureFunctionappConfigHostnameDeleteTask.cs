
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigHostnameDeleteTask : ExternalProcessTaskBase<AzureFunctionappConfigHostnameDeleteTask>
     {
        
        /// <summary>
        /// Unbind a hostname from a function app.
        /// </summary>
        public AzureFunctionappConfigHostnameDeleteTask(string hostname = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config hostname delete");
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
