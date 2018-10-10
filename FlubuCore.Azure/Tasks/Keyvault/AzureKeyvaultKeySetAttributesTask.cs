
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeySetAttributesTask : ExternalProcessTaskBase<AzureKeyvaultKeySetAttributesTask>
     {
        
        /// <summary>
        /// The update key operation changes specified attributes of a stored key and can be applied to any key type and key version stored in Azure Key Vault.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask()
        {
            WithArguments("az keyvault key set-attributes");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Enable the key.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Expires(string expires = null)
        {
            WithArguments("--expires");
            if (!string.IsNullOrEmpty(expires))
            {
                 WithArguments(expires);
            }

            return this;
        }

        /// <summary>
        /// Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask NotBefore(string notBefore = null)
        {
            WithArguments("--not-before");
            if (!string.IsNullOrEmpty(notBefore))
            {
                 WithArguments(notBefore);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of permitted JSON web key operations.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Ops(string ops = null)
        {
            WithArguments("--ops");
            if (!string.IsNullOrEmpty(ops))
            {
                 WithArguments(ops);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Id of the key.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name of the key. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of the key vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask VaultName(string vaultName = null)
        {
            WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

            return this;
        }

        /// <summary>
        /// The key version. If omitted, uses the latest version.
        /// </summary>
        public AzureKeyvaultKeySetAttributesTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }
     }
}
