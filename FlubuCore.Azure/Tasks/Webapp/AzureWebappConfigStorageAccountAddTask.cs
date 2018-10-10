
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigStorageAccountAddTask : ExternalProcessTaskBase<AzureWebappConfigStorageAccountAddTask>
     {
        
        /// <summary>
        /// Add an Azure storage account configuration to a web app.
        /// </summary>
        public AzureWebappConfigStorageAccountAddTask(string accessKey = null ,  string accountName = null ,  string customId = null ,  string name = null ,  string resourceGroup = null ,  string shareName = null ,  string storageType = null)
        {
            WithArguments("az webapp config storage-account add");
WithArguments("--access-key");
            if (!string.IsNullOrEmpty(accessKey))
            {
                 WithArguments(accessKey);
            }

WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

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

WithArguments("--share-name");
            if (!string.IsNullOrEmpty(shareName))
            {
                 WithArguments(shareName);
            }

WithArguments("--storage-type");
            if (!string.IsNullOrEmpty(storageType))
            {
                 WithArguments(storageType);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Path to mount storage volume within web app.
        /// </summary>
        public AzureWebappConfigStorageAccountAddTask MountPath(string mountPath = null)
        {
            WithArguments("--mount-path");
            if (!string.IsNullOrEmpty(mountPath))
            {
                 WithArguments(mountPath);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigStorageAccountAddTask Slot(string slot = null)
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
        public AzureWebappConfigStorageAccountAddTask SlotSetting(string slotSetting = null)
        {
            WithArguments("--slot-setting");
            if (!string.IsNullOrEmpty(slotSetting))
            {
                 WithArguments(slotSetting);
            }

            return this;
        }
     }
}
