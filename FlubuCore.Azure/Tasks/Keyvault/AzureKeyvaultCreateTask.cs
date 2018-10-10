
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCreateTask : ExternalProcessTaskBase<AzureKeyvaultCreateTask>
     {
        
        /// <summary>
        /// Create a key vault.
        /// </summary>
        public AzureKeyvaultCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az keyvault create");
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
        /// Prevents manual purging of deleted vault, and all contained entities.
        /// </summary>
        public AzureKeyvaultCreateTask EnablePurgeProtection(string enablePurgeProtection = null)
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
        public AzureKeyvaultCreateTask EnableSoftDelete(string enableSoftDelete = null)
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
        public AzureKeyvaultCreateTask EnabledForDeployment(string enabledForDeployment = null)
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
        public AzureKeyvaultCreateTask EnabledForDiskEncryption(string enabledForDiskEncryption = null)
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
        public AzureKeyvaultCreateTask EnabledForTemplateDeployment(string enabledForTemplateDeployment = null)
        {
            WithArguments("--enabled-for-template-deployment");
            if (!string.IsNullOrEmpty(enabledForTemplateDeployment))
            {
                 WithArguments(enabledForTemplateDeployment);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureKeyvaultCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Don't add permissions for the current user/service principal in the new vault.
        /// </summary>
        public AzureKeyvaultCreateTask NoSelfPerms(string noSelfPerms = null)
        {
            WithArguments("--no-self-perms");
            if (!string.IsNullOrEmpty(noSelfPerms))
            {
                 WithArguments(noSelfPerms);
            }

            return this;
        }

        /// <summary>
        /// Required. SKU details.
        /// </summary>
        public AzureKeyvaultCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Bypass traffic for space-separated uses.
        /// </summary>
        public AzureKeyvaultCreateTask Bypass(string bypass = null)
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
        public AzureKeyvaultCreateTask DefaultAction(string defaultAction = null)
        {
            WithArguments("--default-action");
            if (!string.IsNullOrEmpty(defaultAction))
            {
                 WithArguments(defaultAction);
            }

            return this;
        }
     }
}
