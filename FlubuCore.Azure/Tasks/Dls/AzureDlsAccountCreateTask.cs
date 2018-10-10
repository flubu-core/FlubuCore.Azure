
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountCreateTask : ExternalProcessTaskBase<AzureDlsAccountCreateTask>
     {
        
        /// <summary>
        /// Creates a Data Lake Store account.
        /// </summary>
        public AzureDlsAccountCreateTask(string account = null)
        {
            WithArguments("az dls account create");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the default group to give permissions to for freshly created files and folders in the Data Lake Store account.
        /// </summary>
        public AzureDlsAccountCreateTask DefaultGroup(string defaultGroup = null)
        {
            WithArguments("--default-group");
            if (!string.IsNullOrEmpty(defaultGroup))
            {
                 WithArguments(defaultGroup);
            }

            return this;
        }

        /// <summary>
        /// Indicates that the account will not have any form of encryption applied to it.
        /// </summary>
        public AzureDlsAccountCreateTask DisableEncryption(string disableEncryption = null)
        {
            WithArguments("--disable-encryption");
            if (!string.IsNullOrEmpty(disableEncryption))
            {
                 WithArguments(disableEncryption);
            }

            return this;
        }

        /// <summary>
        /// Indicates what type of encryption to provision the account with. By default, encryption is ServiceManaged. If no encryption is desired, it must be explicitly set with the --disable-encryption flag.
        /// </summary>
        public AzureDlsAccountCreateTask EncryptionType(string encryptionType = null)
        {
            WithArguments("--encryption-type");
            if (!string.IsNullOrEmpty(encryptionType))
            {
                 WithArguments(encryptionType);
            }

            return this;
        }

        /// <summary>
        /// Key name for the user-assigned encryption type.
        /// </summary>
        public AzureDlsAccountCreateTask KeyName(string keyName = null)
        {
            WithArguments("--key-name");
            if (!string.IsNullOrEmpty(keyName))
            {
                 WithArguments(keyName);
            }

            return this;
        }

        /// <summary>
        /// Key vault for the user-assigned encryption type.
        /// </summary>
        public AzureDlsAccountCreateTask KeyVaultId(string keyVaultId = null)
        {
            WithArguments("--key-vault-id");
            if (!string.IsNullOrEmpty(keyVaultId))
            {
                 WithArguments(keyVaultId);
            }

            return this;
        }

        /// <summary>
        /// Key version for the user-assigned encryption type.
        /// </summary>
        public AzureDlsAccountCreateTask KeyVersion(string keyVersion = null)
        {
            WithArguments("--key-version");
            if (!string.IsNullOrEmpty(keyVersion))
            {
                 WithArguments(keyVersion);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureDlsAccountCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureDlsAccountCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureDlsAccountCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The desired commitment tier for this account to use.
        /// </summary>
        public AzureDlsAccountCreateTask Tier(string tier = null)
        {
            WithArguments("--tier");
            if (!string.IsNullOrEmpty(tier))
            {
                 WithArguments(tier);
            }

            return this;
        }
     }
}
