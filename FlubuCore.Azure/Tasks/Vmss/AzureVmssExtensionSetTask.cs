
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssExtensionSetTask : ExternalProcessTaskBase<AzureVmssExtensionSetTask>
     {
        
        /// <summary>
        /// Add an extension to a VMSS or update an existing extension.
        /// </summary>
        public AzureVmssExtensionSetTask(string name = null ,  string publisher = null ,  string resourceGroup = null ,  string vmssName = null)
        {
            WithArguments("az vmss extension set");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--publisher");
            if (!string.IsNullOrEmpty(publisher))
            {
                 WithArguments(publisher);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vmss-name");
            if (!string.IsNullOrEmpty(vmssName))
            {
                 WithArguments(vmssName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force to update even if the extension configuration has not changed.
        /// </summary>
        public AzureVmssExtensionSetTask ForceUpdate(string forceUpdate = null)
        {
            WithArguments("--force-update");
            if (!string.IsNullOrEmpty(forceUpdate))
            {
                 WithArguments(forceUpdate);
            }

            return this;
        }

        /// <summary>
        /// By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.
        /// </summary>
        public AzureVmssExtensionSetTask NoAutoUpgrade(string noAutoUpgrade = null)
        {
            WithArguments("--no-auto-upgrade");
            if (!string.IsNullOrEmpty(noAutoUpgrade))
            {
                 WithArguments(noAutoUpgrade);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssExtensionSetTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.
        /// </summary>
        public AzureVmssExtensionSetTask ProtectedSettings(string protectedSettings = null)
        {
            WithArguments("--protected-settings");
            if (!string.IsNullOrEmpty(protectedSettings))
            {
                 WithArguments(protectedSettings);
            }

            return this;
        }

        /// <summary>
        /// Extension settings in JSON format. A JSON file path is also accepted.
        /// </summary>
        public AzureVmssExtensionSetTask Settings(string settings = null)
        {
            WithArguments("--settings");
            if (!string.IsNullOrEmpty(settings))
            {
                 WithArguments(settings);
            }

            return this;
        }

        /// <summary>
        /// The version of the extension.
        /// </summary>
        public AzureVmssExtensionSetTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }
     }
}
