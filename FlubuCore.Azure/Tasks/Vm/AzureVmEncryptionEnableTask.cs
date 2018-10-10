
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmEncryptionEnableTask : ExternalProcessTaskBase<AzureVmEncryptionEnableTask>
     {
        
        /// <summary>
        /// Enable disk encryption on the OS disk and/or data disks.
        /// </summary>
        public AzureVmEncryptionEnableTask(string diskEncryptionKeyvault = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm encryption enable");
WithArguments("--disk-encryption-keyvault");
            if (!string.IsNullOrEmpty(diskEncryptionKeyvault))
            {
                 WithArguments(diskEncryptionKeyvault);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Thumbprint of the AAD app certificate with permissions to write secrets to the key vault.
        /// </summary>
        public AzureVmEncryptionEnableTask AadClientCertThumbprint(string aadClientCertThumbprint = null)
        {
            WithArguments("--aad-client-cert-thumbprint");
            if (!string.IsNullOrEmpty(aadClientCertThumbprint))
            {
                 WithArguments(aadClientCertThumbprint);
            }

            return this;
        }

        /// <summary>
        /// Client ID of an AAD app with permissions to write secrets to the key vault.
        /// </summary>
        public AzureVmEncryptionEnableTask AadClientId(string aadClientId = null)
        {
            WithArguments("--aad-client-id");
            if (!string.IsNullOrEmpty(aadClientId))
            {
                 WithArguments(aadClientId);
            }

            return this;
        }

        /// <summary>
        /// Client secret of the AAD app with permissions to write secrets to the key vault.
        /// </summary>
        public AzureVmEncryptionEnableTask AadClientSecret(string aadClientSecret = null)
        {
            WithArguments("--aad-client-secret");
            if (!string.IsNullOrEmpty(aadClientSecret))
            {
                 WithArguments(aadClientSecret);
            }

            return this;
        }

        /// <summary>
        /// Encrypts-formats data disks instead of encrypting them. Encrypt-formatting is a lot faster than in-place encryption but wipes out the partition getting encrypt-formatted.
        /// </summary>
        public AzureVmEncryptionEnableTask EncryptFormatAll(string encryptFormatAll = null)
        {
            WithArguments("--encrypt-format-all");
            if (!string.IsNullOrEmpty(encryptFormatAll))
            {
                 WithArguments(encryptFormatAll);
            }

            return this;
        }

        public AzureVmEncryptionEnableTask KeyEncryptionAlgorithm(string keyEncryptionAlgorithm = null)
        {
            WithArguments("--key-encryption-algorithm");
            if (!string.IsNullOrEmpty(keyEncryptionAlgorithm))
            {
                 WithArguments(keyEncryptionAlgorithm);
            }

            return this;
        }

        /// <summary>
        /// Key vault key name or URL used to encrypt the disk encryption key.
        /// </summary>
        public AzureVmEncryptionEnableTask KeyEncryptionKey(string keyEncryptionKey = null)
        {
            WithArguments("--key-encryption-key");
            if (!string.IsNullOrEmpty(keyEncryptionKey))
            {
                 WithArguments(keyEncryptionKey);
            }

            return this;
        }

        /// <summary>
        /// The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.
        /// </summary>
        public AzureVmEncryptionEnableTask KeyEncryptionKeyvault(string keyEncryptionKeyvault = null)
        {
            WithArguments("--key-encryption-keyvault");
            if (!string.IsNullOrEmpty(keyEncryptionKeyvault))
            {
                 WithArguments(keyEncryptionKeyvault);
            }

            return this;
        }

        /// <summary>
        /// Type of volume that the encryption operation is performed on.
        /// </summary>
        public AzureVmEncryptionEnableTask VolumeType(string volumeType = null)
        {
            WithArguments("--volume-type");
            if (!string.IsNullOrEmpty(volumeType))
            {
                 WithArguments(volumeType);
            }

            return this;
        }
     }
}
