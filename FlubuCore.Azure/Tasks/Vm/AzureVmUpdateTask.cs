
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmUpdateTask : ExternalProcessTaskBase<AzureVmUpdateTask>
     {
        
        /// <summary>
        /// Update the properties of a VM.
        /// </summary>
        public AzureVmUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm update");
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
        /// Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.
        /// </summary>
        public AzureVmUpdateTask DiskCaching(string diskCaching = null)
        {
            WithArguments("--disk-caching");
            if (!string.IsNullOrEmpty(diskCaching))
            {
                 WithArguments(diskCaching);
            }

            return this;
        }

        /// <summary>
        /// License type if the Windows image or disk used was licensed on-premises.
        /// </summary>
        public AzureVmUpdateTask LicenseType(string licenseType = null)
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
        public AzureVmUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Managed OS disk ID or name to swap to. Feature registration for 'Microsoft.Compute/AllowManagedDisksReplaceOSDisk' is needed.
        /// </summary>
        public AzureVmUpdateTask OsDisk(string osDisk = null)
        {
            WithArguments("--os-disk");
            if (!string.IsNullOrEmpty(osDisk))
            {
                 WithArguments(osDisk);
            }

            return this;
        }

        /// <summary>
        /// Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 & 2.
        /// </summary>
        public AzureVmUpdateTask WriteAccelerator(string writeAccelerator = null)
        {
            WithArguments("--write-accelerator");
            if (!string.IsNullOrEmpty(writeAccelerator))
            {
                 WithArguments(writeAccelerator);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureVmUpdateTask Add(string add = null)
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
        public AzureVmUpdateTask ForceString(string forceString = null)
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
        public AzureVmUpdateTask Remove(string remove = null)
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
        public AzureVmUpdateTask Set(string set = null)
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
