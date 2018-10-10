
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSecretDownloadTask : ExternalProcessTaskBase<AzureKeyvaultSecretDownloadTask>
     {
        
        /// <summary>
        /// Download a secret from a KeyVault.
        /// </summary>
        public AzureKeyvaultSecretDownloadTask(string file = null)
        {
            WithArguments("az keyvault secret download");
WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Encoding of the destination file. By default, will look for the 'file-encoding' tag on the secret. Otherwise will assume 'utf-8'.
        /// </summary>
        public AzureKeyvaultSecretDownloadTask Encoding(string encoding = null)
        {
            WithArguments("--encoding");
            if (!string.IsNullOrEmpty(encoding))
            {
                 WithArguments(encoding);
            }

            return this;
        }

        /// <summary>
        /// Id of the secret.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultSecretDownloadTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name of the secret. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultSecretDownloadTask Name(string name = null)
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
        public AzureKeyvaultSecretDownloadTask VaultName(string vaultName = null)
        {
            WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

            return this;
        }

        /// <summary>
        /// The secret version. If omitted, uses the latest version.
        /// </summary>
        public AzureKeyvaultSecretDownloadTask Version(string version = null)
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
