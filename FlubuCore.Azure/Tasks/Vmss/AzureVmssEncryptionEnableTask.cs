
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssEncryptionEnableTask : ExternalProcessTaskBase<AzureVmssEncryptionEnableTask>
     {
        
        /// <summary>
        /// Encrypt a VMSS with managed disks.
        /// </summary>
        public AzureVmssEncryptionEnableTask(string diskEncryptionKeyvault = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss encryption enable");
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
        /// Continue by ignoring client side validation errors.
        /// </summary>
        public AzureVmssEncryptionEnableTask Force(string force = null)
        {
            WithArguments("--force");
            if (!string.IsNullOrEmpty(force))
            {
                 WithArguments(force);
            }

            return this;
        }

        public AzureVmssEncryptionEnableTask KeyEncryptionAlgorithm(string keyEncryptionAlgorithm = null)
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
        public AzureVmssEncryptionEnableTask KeyEncryptionKey(string keyEncryptionKey = null)
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
        public AzureVmssEncryptionEnableTask KeyEncryptionKeyvault(string keyEncryptionKeyvault = null)
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
        public AzureVmssEncryptionEnableTask VolumeType(string volumeType = null)
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
