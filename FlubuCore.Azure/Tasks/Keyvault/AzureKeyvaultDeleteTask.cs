
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultDeleteTask : ExternalProcessTaskBase<AzureKeyvaultDeleteTask>
     {
        
        /// <summary>
        /// Delete a key vault.
        /// </summary>
        public AzureKeyvaultDeleteTask(string name = null)
        {
            WithArguments("az keyvault delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Proceed only if Key Vault belongs to the specified resource group.
        /// </summary>
        public AzureKeyvaultDeleteTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
