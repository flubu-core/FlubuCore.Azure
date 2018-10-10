
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabFormulaDeleteTask : ExternalProcessTaskBase<AzureLabFormulaDeleteTask>
     {
        
        /// <summary>
        /// Delete formula.
        /// </summary>
        public AzureLabFormulaDeleteTask(string labName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab formula delete");
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
