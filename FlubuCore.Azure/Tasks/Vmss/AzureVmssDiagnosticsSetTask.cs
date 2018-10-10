
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssDiagnosticsSetTask : ExternalProcessTaskBase<AzureVmssDiagnosticsSetTask>
     {
        
        /// <summary>
        /// Enable diagnostics on a VMSS.
        /// </summary>
        public AzureVmssDiagnosticsSetTask(string resourceGroup = null ,  string settings = null ,  string vmssName = null)
        {
            WithArguments("az vmss diagnostics set");
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

WithArguments("--vmss-name");
            if (!string.IsNullOrEmpty(vmssName))
            {
                 WithArguments(vmssName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.
        /// </summary>
        public AzureVmssDiagnosticsSetTask NoAutoUpgrade(string noAutoUpgrade = null)
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
        public AzureVmssDiagnosticsSetTask ProtectedSettings(string protectedSettings = null)
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
        public AzureVmssDiagnosticsSetTask Version(string version = null)
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
