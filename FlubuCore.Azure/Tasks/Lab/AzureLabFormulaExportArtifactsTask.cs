
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabFormulaExportArtifactsTask : ExternalProcessTaskBase<AzureLabFormulaExportArtifactsTask>
     {
        
        /// <summary>
        /// Export artifacts from a formula.
        /// </summary>
        public AzureLabFormulaExportArtifactsTask(string labName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab formula export-artifacts");
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
        
     }
}
