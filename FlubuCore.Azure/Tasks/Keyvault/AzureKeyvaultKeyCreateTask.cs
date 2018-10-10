
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyCreateTask : ExternalProcessTaskBase<AzureKeyvaultKeyCreateTask>
     {
        
        /// <summary>
        /// Creates a new key, stores it, then returns key parameters and attributes to the client.
        /// </summary>
        public AzureKeyvaultKeyCreateTask(string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault key create");
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
        /// Elliptic curve name. For valid values, see JsonWebKeyCurveName.
        /// </summary>
        public AzureKeyvaultKeyCreateTask Curve(string curve = null)
        {
            WithArguments("--curve");
            if (!string.IsNullOrEmpty(curve))
            {
                 WithArguments(curve);
            }

            return this;
        }

        /// <summary>
        /// Create key in disabled state.
        /// </summary>
        public AzureKeyvaultKeyCreateTask Disabled(string disabled = null)
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
        public AzureKeyvaultKeyCreateTask Expires(string expires = null)
        {
            WithArguments("--expires");
            if (!string.IsNullOrEmpty(expires))
            {
                 WithArguments(expires);
            }

            return this;
        }

        /// <summary>
        /// The type of key to create. For valid values, see JsonWebKeyType.
        /// </summary>
        public AzureKeyvaultKeyCreateTask Kty(string kty = null)
        {
            WithArguments("--kty");
            if (!string.IsNullOrEmpty(kty))
            {
                 WithArguments(kty);
            }

            return this;
        }

        /// <summary>
        /// Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureKeyvaultKeyCreateTask NotBefore(string notBefore = null)
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
        public AzureKeyvaultKeyCreateTask Ops(string ops = null)
        {
            WithArguments("--ops");
            if (!string.IsNullOrEmpty(ops))
            {
                 WithArguments(ops);
            }

            return this;
        }

        /// <summary>
        /// Specifies the type of key protection.
        /// </summary>
        public AzureKeyvaultKeyCreateTask Protection(string protection = null)
        {
            WithArguments("--protection");
            if (!string.IsNullOrEmpty(protection))
            {
                 WithArguments(protection);
            }

            return this;
        }

        /// <summary>
        /// The key size in bytes. For example, 1024 or 2048.
        /// </summary>
        public AzureKeyvaultKeyCreateTask Size(string size = null)
        {
            WithArguments("--size");
            if (!string.IsNullOrEmpty(size))
            {
                 WithArguments(size);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultKeyCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
