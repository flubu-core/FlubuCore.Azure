
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSetPolicyTask : ExternalProcessTaskBase<AzureKeyvaultSetPolicyTask>
     {
        
        /// <summary>
        /// Update security policy settings for a Key Vault.
        /// </summary>
        public AzureKeyvaultSetPolicyTask(string name = null)
        {
            WithArguments("az keyvault set-policy");
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
        public AzureKeyvaultSetPolicyTask ObjectId(string objectId = null)
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
        public AzureKeyvaultSetPolicyTask ResourceGroup(string resourceGroup = null)
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
        public AzureKeyvaultSetPolicyTask Spn(string spn = null)
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
        public AzureKeyvaultSetPolicyTask Upn(string upn = null)
        {
            WithArguments("--upn");
            if (!string.IsNullOrEmpty(upn))
            {
                 WithArguments(upn);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of certificate permissions to assign.
        /// </summary>
        public AzureKeyvaultSetPolicyTask CertificatePermissions(string certificatePermissions = null)
        {
            WithArguments("--certificate-permissions");
            if (!string.IsNullOrEmpty(certificatePermissions))
            {
                 WithArguments(certificatePermissions);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of key permissions to assign.
        /// </summary>
        public AzureKeyvaultSetPolicyTask KeyPermissions(string keyPermissions = null)
        {
            WithArguments("--key-permissions");
            if (!string.IsNullOrEmpty(keyPermissions))
            {
                 WithArguments(keyPermissions);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of secret permissions to assign.
        /// </summary>
        public AzureKeyvaultSetPolicyTask SecretPermissions(string secretPermissions = null)
        {
            WithArguments("--secret-permissions");
            if (!string.IsNullOrEmpty(secretPermissions))
            {
                 WithArguments(secretPermissions);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of storage permissions to assign.
        /// </summary>
        public AzureKeyvaultSetPolicyTask StoragePermissions(string storagePermissions = null)
        {
            WithArguments("--storage-permissions");
            if (!string.IsNullOrEmpty(storagePermissions))
            {
                 WithArguments(storagePermissions);
            }

            return this;
        }
     }
}
