
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAssetGetSasUrlsTask : ExternalProcessTaskBase<AzureAmsAssetGetSasUrlsTask>
     {
        
        /// <summary>
        /// Lists the asset SAS URLs used for uploading and downloading asset content.
        /// </summary>
        public AzureAmsAssetGetSasUrlsTask(string accountName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams asset get-sas-urls");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
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
        /// Specifies the UTC datetime (Y-m-d'T'H:M:S'Z') at which the SAS becomes invalid.
        /// </summary>
        public AzureAmsAssetGetSasUrlsTask Expiry(string expiry = null)
        {
            WithArguments("--expiry");
            if (!string.IsNullOrEmpty(expiry))
            {
                 WithArguments(expiry);
            }

            return this;
        }

        /// <summary>
        /// The permissions to set on the SAS URL.
        /// </summary>
        public AzureAmsAssetGetSasUrlsTask Permissions(string permissions = null)
        {
            WithArguments("--permissions");
            if (!string.IsNullOrEmpty(permissions))
            {
                 WithArguments(permissions);
            }

            return this;
        }
     }
}
