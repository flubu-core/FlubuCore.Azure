
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabVmClaimTask : ExternalProcessTaskBase<AzureLabVmClaimTask>
     {
        
        /// <summary>
        /// Claim a virtual machine from the Lab.
        /// </summary>
        public AzureLabVmClaimTask()
        {
            WithArguments("az lab vm claim");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the lab.
        /// </summary>
        public AzureLabVmClaimTask LabName(string labName = null)
        {
            WithArguments("--lab-name");
            if (!string.IsNullOrEmpty(labName))
            {
                 WithArguments(labName);
            }

            return this;
        }

        /// <summary>
        /// Name of the virtual machine to claim.
        /// </summary>
        public AzureLabVmClaimTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of lab's resource group.
        /// </summary>
        public AzureLabVmClaimTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
