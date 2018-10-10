
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cloud
{
     public partial class AzureCloudRegisterTask : ExternalProcessTaskBase<AzureCloudRegisterTask>
     {
        
        /// <summary>
        /// Register a cloud.
        /// </summary>
        public AzureCloudRegisterTask(string name = null)
        {
            WithArguments("az cloud register");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// JSON encoded cloud configuration. Use @{file} to load from a file.
        /// </summary>
        public AzureCloudRegisterTask CloudConfig(string cloudConfig = null)
        {
            WithArguments("--cloud-config");
            if (!string.IsNullOrEmpty(cloudConfig))
            {
                 WithArguments(cloudConfig);
            }

            return this;
        }

        /// <summary>
        /// The Active Directory login endpoint.
        /// </summary>
        public AzureCloudRegisterTask EndpointActiveDirectory(string endpointActiveDirectory = null)
        {
            WithArguments("--endpoint-active-directory");
            if (!string.IsNullOrEmpty(endpointActiveDirectory))
            {
                 WithArguments(endpointActiveDirectory);
            }

            return this;
        }

        /// <summary>
        /// The Active Directory resource ID for data lake services.
        /// </summary>
        public AzureCloudRegisterTask EndpointActiveDirectoryDataLakeResourceId(string endpointActiveDirectoryDataLakeResourceId = null)
        {
            WithArguments("--endpoint-active-directory-data-lake-resource-id");
            if (!string.IsNullOrEmpty(endpointActiveDirectoryDataLakeResourceId))
            {
                 WithArguments(endpointActiveDirectoryDataLakeResourceId);
            }

            return this;
        }

        /// <summary>
        /// The Active Directory resource ID.
        /// </summary>
        public AzureCloudRegisterTask EndpointActiveDirectoryGraphResourceId(string endpointActiveDirectoryGraphResourceId = null)
        {
            WithArguments("--endpoint-active-directory-graph-resource-id");
            if (!string.IsNullOrEmpty(endpointActiveDirectoryGraphResourceId))
            {
                 WithArguments(endpointActiveDirectoryGraphResourceId);
            }

            return this;
        }

        /// <summary>
        /// The resource ID to obtain AD tokens for.
        /// </summary>
        public AzureCloudRegisterTask EndpointActiveDirectoryResourceId(string endpointActiveDirectoryResourceId = null)
        {
            WithArguments("--endpoint-active-directory-resource-id");
            if (!string.IsNullOrEmpty(endpointActiveDirectoryResourceId))
            {
                 WithArguments(endpointActiveDirectoryResourceId);
            }

            return this;
        }

        /// <summary>
        /// The template gallery endpoint.
        /// </summary>
        public AzureCloudRegisterTask EndpointGallery(string endpointGallery = null)
        {
            WithArguments("--endpoint-gallery");
            if (!string.IsNullOrEmpty(endpointGallery))
            {
                 WithArguments(endpointGallery);
            }

            return this;
        }

        /// <summary>
        /// The management service endpoint.
        /// </summary>
        public AzureCloudRegisterTask EndpointManagement(string endpointManagement = null)
        {
            WithArguments("--endpoint-management");
            if (!string.IsNullOrEmpty(endpointManagement))
            {
                 WithArguments(endpointManagement);
            }

            return this;
        }

        /// <summary>
        /// The resource management endpoint.
        /// </summary>
        public AzureCloudRegisterTask EndpointResourceManager(string endpointResourceManager = null)
        {
            WithArguments("--endpoint-resource-manager");
            if (!string.IsNullOrEmpty(endpointResourceManager))
            {
                 WithArguments(endpointResourceManager);
            }

            return this;
        }

        /// <summary>
        /// The sql server management endpoint.
        /// </summary>
        public AzureCloudRegisterTask EndpointSqlManagement(string endpointSqlManagement = null)
        {
            WithArguments("--endpoint-sql-management");
            if (!string.IsNullOrEmpty(endpointSqlManagement))
            {
                 WithArguments(endpointSqlManagement);
            }

            return this;
        }

        /// <summary>
        /// The uri of the document which caches commonly used virtual machine images.
        /// </summary>
        public AzureCloudRegisterTask EndpointVmImageAliasDoc(string endpointVmImageAliasDoc = null)
        {
            WithArguments("--endpoint-vm-image-alias-doc");
            if (!string.IsNullOrEmpty(endpointVmImageAliasDoc))
            {
                 WithArguments(endpointVmImageAliasDoc);
            }

            return this;
        }

        /// <summary>
        /// Profile to use for this cloud.
        /// </summary>
        public AzureCloudRegisterTask Profile(string profile = null)
        {
            WithArguments("--profile");
            if (!string.IsNullOrEmpty(profile))
            {
                 WithArguments(profile);
            }

            return this;
        }

        /// <summary>
        /// The Azure Container Registry login server suffix.
        /// </summary>
        public AzureCloudRegisterTask SuffixAcrLoginServerEndpoint(string suffixAcrLoginServerEndpoint = null)
        {
            WithArguments("--suffix-acr-login-server-endpoint");
            if (!string.IsNullOrEmpty(suffixAcrLoginServerEndpoint))
            {
                 WithArguments(suffixAcrLoginServerEndpoint);
            }

            return this;
        }

        /// <summary>
        /// The Data Lake analytics job and catalog service dns suffix.
        /// </summary>
        public AzureCloudRegisterTask SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint(string suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint = null)
        {
            WithArguments("--suffix-azure-datalake-analytics-catalog-and-job-endpoint");
            if (!string.IsNullOrEmpty(suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint))
            {
                 WithArguments(suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint);
            }

            return this;
        }

        /// <summary>
        /// The Data Lake store filesystem service dns suffix.
        /// </summary>
        public AzureCloudRegisterTask SuffixAzureDatalakeStoreFileSystemEndpoint(string suffixAzureDatalakeStoreFileSystemEndpoint = null)
        {
            WithArguments("--suffix-azure-datalake-store-file-system-endpoint");
            if (!string.IsNullOrEmpty(suffixAzureDatalakeStoreFileSystemEndpoint))
            {
                 WithArguments(suffixAzureDatalakeStoreFileSystemEndpoint);
            }

            return this;
        }

        /// <summary>
        /// The Key Vault service dns suffix.
        /// </summary>
        public AzureCloudRegisterTask SuffixKeyvaultDns(string suffixKeyvaultDns = null)
        {
            WithArguments("--suffix-keyvault-dns");
            if (!string.IsNullOrEmpty(suffixKeyvaultDns))
            {
                 WithArguments(suffixKeyvaultDns);
            }

            return this;
        }

        /// <summary>
        /// The dns suffix for sql servers.
        /// </summary>
        public AzureCloudRegisterTask SuffixSqlServerHostname(string suffixSqlServerHostname = null)
        {
            WithArguments("--suffix-sql-server-hostname");
            if (!string.IsNullOrEmpty(suffixSqlServerHostname))
            {
                 WithArguments(suffixSqlServerHostname);
            }

            return this;
        }

        /// <summary>
        /// The endpoint suffix for storage accounts.
        /// </summary>
        public AzureCloudRegisterTask SuffixStorageEndpoint(string suffixStorageEndpoint = null)
        {
            WithArguments("--suffix-storage-endpoint");
            if (!string.IsNullOrEmpty(suffixStorageEndpoint))
            {
                 WithArguments(suffixStorageEndpoint);
            }

            return this;
        }
     }
}
