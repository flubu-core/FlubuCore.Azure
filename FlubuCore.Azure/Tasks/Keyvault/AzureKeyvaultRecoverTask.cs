
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultRecoverTask : ExternalProcessTaskBase<AzureKeyvaultRecoverTask>
     {
        
        /// <summary>
        /// Recover a key vault.
        /// </summary>
        public AzureKeyvaultRecoverTask(string location = null ,  string name = null)
        {
            WithArguments("az keyvault recover");
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
        
        /// <summary>
        /// Proceed only if Key Vault belongs to the specified resource group.
        /// </summary>
        public AzureKeyvaultRecoverTask ResourceGroup(string resourceGroup = null)
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
