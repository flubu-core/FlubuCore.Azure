
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Alias
{
     public partial class AzureAliasCreateTask : ExternalProcessTaskBase<AzureAliasCreateTask>
     {
        
        /// <summary>
        /// Create an alias.
        /// </summary>
        public AzureAliasCreateTask(string command = null ,  string name = null)
        {
            WithArguments("az alias create");
WithArguments("--command");
            if (!string.IsNullOrEmpty(command))
            {
                 WithArguments(command);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
