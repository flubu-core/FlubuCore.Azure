
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureConfigureTask : ExternalProcessTaskBase<AzureConfigureTask>
     {
        
        /// <summary>
        /// Manage Azure CLI configuration. This command is interactive.
        /// </summary>
        public AzureConfigureTask()
        {
            WithArguments("az configure");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated 'name=value' pairs for common argument defaults.
        /// </summary>
        public AzureConfigureTask Defaults(string defaults = null)
        {
            WithArguments("--defaults");
            if (!string.IsNullOrEmpty(defaults))
            {
                 WithArguments(defaults);
            }

            return this;
        }
     }
}
