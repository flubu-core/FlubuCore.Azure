
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerUpdateTask : ExternalProcessTaskBase<AzureMariadbServerUpdateTask>
     {
        
        /// <summary>
        /// Update a server.
        /// </summary>
        public AzureMariadbServerUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az mariadb server update");
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
        /// The password of the administrator login.
        /// </summary>
        public AzureMariadbServerUpdateTask AdminPassword(string adminPassword = null)
        {
            WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

            return this;
        }

        /// <summary>
        /// The number of days a backup is retained.
        /// </summary>
        public AzureMariadbServerUpdateTask BackupRetention(string backupRetention = null)
        {
            WithArguments("--backup-retention");
            if (!string.IsNullOrEmpty(backupRetention))
            {
                 WithArguments(backupRetention);
            }

            return this;
        }

        /// <summary>
        /// The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.
        /// </summary>
        public AzureMariadbServerUpdateTask SkuName(string skuName = null)
        {
            WithArguments("--sku-name");
            if (!string.IsNullOrEmpty(skuName))
            {
                 WithArguments(skuName);
            }

            return this;
        }

        /// <summary>
        /// Enable ssl enforcement or not when connect to server.
        /// </summary>
        public AzureMariadbServerUpdateTask SslEnforcement(string sslEnforcement = null)
        {
            WithArguments("--ssl-enforcement");
            if (!string.IsNullOrEmpty(sslEnforcement))
            {
                 WithArguments(sslEnforcement);
            }

            return this;
        }

        /// <summary>
        /// The max storage size of the server. Unit is megabytes.
        /// </summary>
        public AzureMariadbServerUpdateTask StorageSize(string storageSize = null)
        {
            WithArguments("--storage-size");
            if (!string.IsNullOrEmpty(storageSize))
            {
                 WithArguments(storageSize);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMariadbServerUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureMariadbServerUpdateTask Add(string add = null)
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
        public AzureMariadbServerUpdateTask ForceString(string forceString = null)
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
        public AzureMariadbServerUpdateTask Remove(string remove = null)
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
        public AzureMariadbServerUpdateTask Set(string set = null)
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
