
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrCreateTask : ExternalProcessTaskBase<AzureAcrCreateTask>
     {
        
        /// <summary>
        /// Creates an Azure Container Registry.
        /// </summary>
        public AzureAcrCreateTask(string name = null ,  string resourceGroup = null ,  string sku = null)
        {
            WithArguments("az acr create");
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

WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates whether the admin user is enabled.
        /// </summary>
        public AzureAcrCreateTask AdminEnabled(string adminEnabled = null)
        {
            WithArguments("--admin-enabled");
            if (!string.IsNullOrEmpty(adminEnabled))
            {
                 WithArguments(adminEnabled);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAcrCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.
        /// </summary>
        public AzureAcrCreateTask StorageAccountName(string storageAccountName = null)
        {
            WithArguments("--storage-account-name");
            if (!string.IsNullOrEmpty(storageAccountName))
            {
                 WithArguments(storageAccountName);
            }

            return this;
        }
     }
}
