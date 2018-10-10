
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultUpdateTask : ExternalProcessTaskBase<AzureKeyvaultUpdateTask>
     {
        
        /// <summary>
        /// Update the properties of a key vault.
        /// </summary>
        public AzureKeyvaultUpdateTask(string name = null)
        {
            WithArguments("az keyvault update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Prevents manual purging of deleted vault, and all contained entities.
        /// </summary>
        public AzureKeyvaultUpdateTask EnablePurgeProtection(string enablePurgeProtection = null)
        {
            WithArguments("--enable-purge-protection");
            if (!string.IsNullOrEmpty(enablePurgeProtection))
            {
                 WithArguments(enablePurgeProtection);
            }

            return this;
        }

        /// <summary>
        /// Enable vault deletion recovery for the vault, and all contained entities.
        /// </summary>
        public AzureKeyvaultUpdateTask EnableSoftDelete(string enableSoftDelete = null)
        {
            WithArguments("--enable-soft-delete");
            if (!string.IsNullOrEmpty(enableSoftDelete))
            {
                 WithArguments(enableSoftDelete);
            }

            return this;
        }

        /// <summary>
        /// Allow Virtual Machines to retrieve certificates stored as secrets from the vault.
        /// </summary>
        public AzureKeyvaultUpdateTask EnabledForDeployment(string enabledForDeployment = null)
        {
            WithArguments("--enabled-for-deployment");
            if (!string.IsNullOrEmpty(enabledForDeployment))
            {
                 WithArguments(enabledForDeployment);
            }

            return this;
        }

        /// <summary>
        /// Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        public AzureKeyvaultUpdateTask EnabledForDiskEncryption(string enabledForDiskEncryption = null)
        {
            WithArguments("--enabled-for-disk-encryption");
            if (!string.IsNullOrEmpty(enabledForDiskEncryption))
            {
                 WithArguments(enabledForDiskEncryption);
            }

            return this;
        }

        /// <summary>
        /// Allow Resource Manager to retrieve secrets from the vault.
        /// </summary>
        public AzureKeyvaultUpdateTask EnabledForTemplateDeployment(string enabledForTemplateDeployment = null)
        {
            WithArguments("--enabled-for-template-deployment");
            if (!string.IsNullOrEmpty(enabledForTemplateDeployment))
            {
                 WithArguments(enabledForTemplateDeployment);
            }

            return this;
        }

        /// <summary>
        /// Proceed only if Key Vault belongs to the specified resource group.
        /// </summary>
        public AzureKeyvaultUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Bypass traffic for space-separated uses.
        /// </summary>
        public AzureKeyvaultUpdateTask Bypass(string bypass = null)
        {
            WithArguments("--bypass");
            if (!string.IsNullOrEmpty(bypass))
            {
                 WithArguments(bypass);
            }

            return this;
        }

        /// <summary>
        /// Default action to apply when no rule matches.
        /// </summary>
        public AzureKeyvaultUpdateTask DefaultAction(string defaultAction = null)
        {
            WithArguments("--default-action");
            if (!string.IsNullOrEmpty(defaultAction))
            {
                 WithArguments(defaultAction);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureKeyvaultUpdateTask Add(string add = null)
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
        public AzureKeyvaultUpdateTask ForceString(string forceString = null)
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
        public AzureKeyvaultUpdateTask Remove(string remove = null)
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
        public AzureKeyvaultUpdateTask Set(string set = null)
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
