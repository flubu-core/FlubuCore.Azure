
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Alias
{
     public partial class AzureAliasRemoveAllTask : ExternalProcessTaskBase<AzureAliasRemoveAllTask>
     {
        
        /// <summary>
        /// Remove all registered aliases.
        /// </summary>
        public AzureAliasRemoveAllTask()
        {
            WithArguments("az alias remove-all");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureAliasRemoveAllTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
