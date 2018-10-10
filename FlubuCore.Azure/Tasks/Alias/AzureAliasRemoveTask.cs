
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Alias
{
     public partial class AzureAliasRemoveTask : ExternalProcessTaskBase<AzureAliasRemoveTask>
     {
        
        /// <summary>
        /// Remove one or more aliases. Aliases to be removed are space-delimited.
        /// </summary>
        public AzureAliasRemoveTask(string name = null)
        {
            WithArguments("az alias remove");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
