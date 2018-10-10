
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmDiagnosticsSetTask : ExternalProcessTaskBase<AzureVmDiagnosticsSetTask>
     {
        
        /// <summary>
        /// Configure the Azure VM diagnostics extension.
        /// </summary>
        public AzureVmDiagnosticsSetTask(string resourceGroup = null ,  string settings = null ,  string vmName = null)
        {
            WithArguments("az vm diagnostics set");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--settings");
            if (!string.IsNullOrEmpty(settings))
            {
                 WithArguments(settings);
            }

WithArguments("--vm-name");
            if (!string.IsNullOrEmpty(vmName))
            {
                 WithArguments(vmName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.
        /// </summary>
        public AzureVmDiagnosticsSetTask NoAutoUpgrade(string noAutoUpgrade = null)
        {
            WithArguments("--no-auto-upgrade");
            if (!string.IsNullOrEmpty(noAutoUpgrade))
            {
                 WithArguments(noAutoUpgrade);
            }

            return this;
        }

        /// <summary>
        /// Json string or a file path containing private configurations such as storage account keys, etc.
        /// </summary>
        public AzureVmDiagnosticsSetTask ProtectedSettings(string protectedSettings = null)
        {
            WithArguments("--protected-settings");
            if (!string.IsNullOrEmpty(protectedSettings))
            {
                 WithArguments(protectedSettings);
            }

            return this;
        }

        /// <summary>
        /// Version of the diagnostics extension. Will use the latest if not specfied.
        /// </summary>
        public AzureVmDiagnosticsSetTask Version(string version = null)
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
