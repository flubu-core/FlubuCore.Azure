
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultDeletePolicyTask : ExternalProcessTaskBase<AzureKeyvaultDeletePolicyTask>
     {
        
        /// <summary>
        /// Delete security policy settings for a Key Vault.
        /// </summary>
        public AzureKeyvaultDeletePolicyTask(string name = null)
        {
            WithArguments("az keyvault delete-policy");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A GUID that identifies the principal that will receive permissions.
        /// </summary>
        public AzureKeyvaultDeletePolicyTask ObjectId(string objectId = null)
        {
            WithArguments("--object-id");
            if (!string.IsNullOrEmpty(objectId))
            {
                 WithArguments(objectId);
            }

            return this;
        }

        /// <summary>
        /// Proceed only if Key Vault belongs to the specified resource group.
        /// </summary>
        public AzureKeyvaultDeletePolicyTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Name of a service principal that will receive permissions.
        /// </summary>
        public AzureKeyvaultDeletePolicyTask Spn(string spn = null)
        {
            WithArguments("--spn");
            if (!string.IsNullOrEmpty(spn))
            {
                 WithArguments(spn);
            }

            return this;
        }

        /// <summary>
        /// Name of a user principal that will receive permissions.
        /// </summary>
        public AzureKeyvaultDeletePolicyTask Upn(string upn = null)
        {
            WithArguments("--upn");
            if (!string.IsNullOrEmpty(upn))
            {
                 WithArguments(upn);
            }

            return this;
        }
     }
}
