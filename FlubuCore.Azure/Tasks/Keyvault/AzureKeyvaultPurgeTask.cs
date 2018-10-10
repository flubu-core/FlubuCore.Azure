
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultPurgeTask : ExternalProcessTaskBase<AzureKeyvaultPurgeTask>
     {
        
        /// <summary>
        /// Permanently deletes the specified vault.
        /// </summary>
        public AzureKeyvaultPurgeTask(string location = null ,  string name = null)
        {
            WithArguments("az keyvault purge");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
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
