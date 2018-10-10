
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabVmApplyArtifactsTask : ExternalProcessTaskBase<AzureLabVmApplyArtifactsTask>
     {
        
        /// <summary>
        /// Apply artifacts to a virtual machine in Azure DevTest Lab.
        /// </summary>
        public AzureLabVmApplyArtifactsTask(string labName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab vm apply-artifacts");
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.
        /// </summary>
        public AzureLabVmApplyArtifactsTask Artifacts(string artifacts = null)
        {
            WithArguments("--artifacts");
            if (!string.IsNullOrEmpty(artifacts))
            {
                 WithArguments(artifacts);
            }

            return this;
        }
     }
}
