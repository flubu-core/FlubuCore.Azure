
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssEncryptionDisableTask : ExternalProcessTaskBase<AzureVmssEncryptionDisableTask>
     {
        
        /// <summary>
        /// Disable the encryption on a VMSS with managed disks.
        /// </summary>
        public AzureVmssEncryptionDisableTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss encryption disable");
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
        public AzureVmssEncryptionDisableTask Force(string force = null)
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
        public AzureVmssEncryptionDisableTask VolumeType(string volumeType = null)
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
