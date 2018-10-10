
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSecretSetTask : ExternalProcessTaskBase<AzureKeyvaultSecretSetTask>
     {
        
        /// <summary>
        /// Sets a secret in a specified key vault.
        /// </summary>
        public AzureKeyvaultSecretSetTask(string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault secret set");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create secret in disabled state.
        /// </summary>
        public AzureKeyvaultSecretSetTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureKeyvaultSecretSetTask Expires(string expires = null)
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
        public AzureKeyvaultSecretSetTask NotBefore(string notBefore = null)
        {
            WithArguments("--not-before");
            if (!string.IsNullOrEmpty(notBefore))
            {
                 WithArguments(notBefore);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultSecretSetTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Source file encoding. The value is saved as a tag (`file-encoding=&lt;val&gt;`) and used during download to automatically encode the resulting file.
        /// </summary>
        public AzureKeyvaultSecretSetTask Encoding(string encoding = null)
        {
            WithArguments("--encoding");
            if (!string.IsNullOrEmpty(encoding))
            {
                 WithArguments(encoding);
            }

            return this;
        }

        /// <summary>
        /// Source file for secret. Use in conjunction with '--encoding'.
        /// </summary>
        public AzureKeyvaultSecretSetTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }

        /// <summary>
        /// Plain text secret value. Cannot be used with '--file' or '--encoding'.
        /// </summary>
        public AzureKeyvaultSecretSetTask Value(string value = null)
        {
            WithArguments("--value");
            if (!string.IsNullOrEmpty(value))
            {
                 WithArguments(value);
            }

            return this;
        }
     }
}
