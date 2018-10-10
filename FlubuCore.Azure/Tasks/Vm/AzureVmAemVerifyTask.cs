
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAemVerifyTask : ExternalProcessTaskBase<AzureVmAemVerifyTask>
     {
        
        /// <summary>
        /// Verify Azure Enhanced Monitoring Extensions configured correctly.
        /// </summary>
        public AzureVmAemVerifyTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm aem verify");
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
        /// Disables the test for table content.
        /// </summary>
        public AzureVmAemVerifyTask SkipStorageCheck(string skipStorageCheck = null)
        {
            WithArguments("--skip-storage-check");
            if (!string.IsNullOrEmpty(skipStorageCheck))
            {
                 WithArguments(skipStorageCheck);
            }

            return this;
        }

        /// <summary>
        /// Maximum minutes to wait for the storage metrics to be available.
        /// </summary>
        public AzureVmAemVerifyTask WaitTimeInMinutes(string waitTimeInMinutes = null)
        {
            WithArguments("--wait-time-in-minutes");
            if (!string.IsNullOrEmpty(waitTimeInMinutes))
            {
                 WithArguments(waitTimeInMinutes);
            }

            return this;
        }
     }
}
