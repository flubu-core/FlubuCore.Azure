
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmEncryptionDisableTask : ExternalProcessTaskBase<AzureVmEncryptionDisableTask>
     {
        
        /// <summary>
        /// Disable disk encryption on the OS disk and/or data disks.
        /// </summary>
        public AzureVmEncryptionDisableTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm encryption disable");
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
        /// Continue by ignoring client side validation errors.
        /// </summary>
        public AzureVmEncryptionDisableTask Force(string force = null)
        {
            WithArguments("--force");
            if (!string.IsNullOrEmpty(force))
            {
                 WithArguments(force);
            }

            return this;
        }

        /// <summary>
        /// Type of volume that the encryption operation is performed on.
        /// </summary>
        public AzureVmEncryptionDisableTask VolumeType(string volumeType = null)
        {
            WithArguments("--volume-type");
            if (!string.IsNullOrEmpty(volumeType))
            {
                 WithArguments(volumeType);
            }

            return this;
        }
     }
}
