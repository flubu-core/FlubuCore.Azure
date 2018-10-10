
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabFormulaTask : ExternalProcessTaskBase<AzureLabFormulaTask>
     {
        
        /// <summary>
        /// Manage formulas for an Azure DevTest Lab.
        /// </summary>
        public AzureLabFormulaTask()
        {
            WithArguments("az lab formula");
        }

        protected override string Description { get; set; }
        
     }
}
