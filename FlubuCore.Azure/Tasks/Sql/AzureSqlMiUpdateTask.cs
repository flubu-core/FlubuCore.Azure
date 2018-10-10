
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlMiUpdateTask : ExternalProcessTaskBase<AzureSqlMiUpdateTask>
     {
        
        /// <summary>
        /// Update a managed instance.
        /// </summary>
        public AzureSqlMiUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az sql mi update");
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
        /// The administrator login password (required for managed instance creation).
        /// </summary>
        public AzureSqlMiUpdateTask AdminPassword(string adminPassword = null)
        {
            WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

            return this;
        }

        /// <summary>
        /// Generate and assign an Azure Active Directory Identity for this managed instance for use with key management services like Azure KeyVault. If identity is already assigned - do nothing.
        /// </summary>
        public AzureSqlMiUpdateTask AssignIdentity(string assignIdentity = null)
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
        public AzureSqlMiUpdateTask Capacity(string capacity = null)
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
        public AzureSqlMiUpdateTask LicenseType(string licenseType = null)
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
        public AzureSqlMiUpdateTask NoWait(string noWait = null)
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
        public AzureSqlMiUpdateTask Storage(string storage = null)
        {
            WithArguments("--storage");
            if (!string.IsNullOrEmpty(storage))
            {
                 WithArguments(storage);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureSqlMiUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureSqlMiUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureSqlMiUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureSqlMiUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
