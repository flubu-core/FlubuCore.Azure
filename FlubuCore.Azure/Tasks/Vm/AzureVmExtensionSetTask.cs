
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmExtensionSetTask : ExternalProcessTaskBase<AzureVmExtensionSetTask>
     {
        
        /// <summary>
        /// Set extensions for a VM.
        /// </summary>
        public AzureVmExtensionSetTask(string name = null ,  string publisher = null ,  string resourceGroup = null ,  string vmName = null)
        {
            WithArguments("az vm extension set");
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

WithArguments("--vm-name");
            if (!string.IsNullOrEmpty(vmName))
            {
                 WithArguments(vmName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force to update even if the extension configuration has not changed.
        /// </summary>
        public AzureVmExtensionSetTask ForceUpdate(string forceUpdate = null)
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
        public AzureVmExtensionSetTask NoAutoUpgrade(string noAutoUpgrade = null)
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
        public AzureVmExtensionSetTask NoWait(string noWait = null)
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
        public AzureVmExtensionSetTask ProtectedSettings(string protectedSettings = null)
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
        public AzureVmExtensionSetTask Settings(string settings = null)
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
        public AzureVmExtensionSetTask Version(string version = null)
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
