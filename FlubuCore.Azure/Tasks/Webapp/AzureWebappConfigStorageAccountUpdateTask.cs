
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigStorageAccountUpdateTask : ExternalProcessTaskBase<AzureWebappConfigStorageAccountUpdateTask>
     {
        
        /// <summary>
        /// Update an existing Azure storage account configuration on a web app.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask(string customId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config storage-account update");
WithArguments("--custom-id");
            if (!string.IsNullOrEmpty(customId))
            {
                 WithArguments(customId);
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
        /// Storage account access key.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask AccessKey(string accessKey = null)
        {
            WithArguments("--access-key");
            if (!string.IsNullOrEmpty(accessKey))
            {
                 WithArguments(accessKey);
            }

            return this;
        }

        /// <summary>
        /// Storage account name.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Path to mount storage volume within web app.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask MountPath(string mountPath = null)
        {
            WithArguments("--mount-path");
            if (!string.IsNullOrEmpty(mountPath))
            {
                 WithArguments(mountPath);
            }

            return this;
        }

        /// <summary>
        /// Share name (Azure Files) or container name (Azure Blob Storage).
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask ShareName(string shareName = null)
        {
            WithArguments("--share-name");
            if (!string.IsNullOrEmpty(shareName))
            {
                 WithArguments(shareName);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Slot setting.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask SlotSetting(string slotSetting = null)
        {
            WithArguments("--slot-setting");
            if (!string.IsNullOrEmpty(slotSetting))
            {
                 WithArguments(slotSetting);
            }

            return this;
        }

        /// <summary>
        /// Storage type.
        /// </summary>
        public AzureWebappConfigStorageAccountUpdateTask StorageType(string storageType = null)
        {
            WithArguments("--storage-type");
            if (!string.IsNullOrEmpty(storageType))
            {
                 WithArguments(storageType);
            }

            return this;
        }
     }
}
