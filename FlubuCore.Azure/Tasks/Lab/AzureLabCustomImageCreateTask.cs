
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabCustomImageCreateTask : ExternalProcessTaskBase<AzureLabCustomImageCreateTask>
     {
        
        /// <summary>
        /// Create a custom image in a DevTest Lab.
        /// </summary>
        public AzureLabCustomImageCreateTask(string labName = null ,  string name = null ,  string osState = null ,  string osType = null ,  string resourceGroup = null ,  string sourceVmId = null)
        {
            WithArguments("az lab custom-image create");
WithArguments("--lab-name");
            if (!string.IsNullOrEmpty(labName))
            {
                 WithArguments(labName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--os-state");
            if (!string.IsNullOrEmpty(osState))
            {
                 WithArguments(osState);
            }

WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--source-vm-id");
            if (!string.IsNullOrEmpty(sourceVmId))
            {
                 WithArguments(sourceVmId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The author of the custom image.
        /// </summary>
        public AzureLabCustomImageCreateTask Author(string author = null)
        {
            WithArguments("--author");
            if (!string.IsNullOrEmpty(author))
            {
                 WithArguments(author);
            }

            return this;
        }
     }
}
