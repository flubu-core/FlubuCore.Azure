
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlMiCreateTask : ExternalProcessTaskBase<AzureSqlMiCreateTask>
     {
        
        /// <summary>
        /// Create a managed instance.
        /// </summary>
        public AzureSqlMiCreateTask(string adminPassword = null ,  string adminUser = null ,  string location = null ,  string name = null ,  string resourceGroup = null ,  string subnet = null)
        {
            WithArguments("az sql mi create");
WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

WithArguments("--admin-user");
            if (!string.IsNullOrEmpty(adminUser))
            {
                 WithArguments(adminUser);
            }

WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
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

WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Generate and assign an Azure Active Directory Identity for this managed instance for use with key management services like Azure KeyVault.
        /// </summary>
        public AzureSqlMiCreateTask AssignIdentity(string assignIdentity = null)
        {
            WithArguments("--assign-identity");
            if (!string.IsNullOrEmpty(assignIdentity))
            {
                 WithArguments(assignIdentity);
            }

            return this;
        }

        /// <summary>
        /// The capacity of the managed instance in vcores.
        /// </summary>
        public AzureSqlMiCreateTask Capacity(string capacity = null)
        {
            WithArguments("--capacity");
            if (!string.IsNullOrEmpty(capacity))
            {
                 WithArguments(capacity);
            }

            return this;
        }

        /// <summary>
        /// The license type to apply for this managed instance.
        /// </summary>
        public AzureSqlMiCreateTask LicenseType(string licenseType = null)
        {
            WithArguments("--license-type");
            if (!string.IsNullOrEmpty(licenseType))
            {
                 WithArguments(licenseType);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureSqlMiCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The storage size of the managed instance. Storage size must be specified in increments of 32 GB.
        /// </summary>
        public AzureSqlMiCreateTask Storage(string storage = null)
        {
            WithArguments("--storage");
            if (!string.IsNullOrEmpty(storage))
            {
                 WithArguments(storage);
            }

            return this;
        }

        /// <summary>
        /// The virtual network name.
        /// </summary>
        public AzureSqlMiCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }

        /// <summary>
        /// The edition component of the sku. Allowed value is GeneralPurpose.
        /// </summary>
        public AzureSqlMiCreateTask Edition(string edition = null)
        {
            WithArguments("--edition");
            if (!string.IsNullOrEmpty(edition))
            {
                 WithArguments(edition);
            }

            return this;
        }

        /// <summary>
        /// The compute generation component of the sku. Allowed values include: Gen4, Gen5.
        /// </summary>
        public AzureSqlMiCreateTask Family(string family = null)
        {
            WithArguments("--family");
            if (!string.IsNullOrEmpty(family))
            {
                 WithArguments(family);
            }

            return this;
        }
     }
}
