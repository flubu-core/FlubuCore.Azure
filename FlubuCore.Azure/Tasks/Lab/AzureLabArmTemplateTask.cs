
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabArmTemplateTask : ExternalProcessTaskBase<AzureLabArmTemplateTask>
     {
        
        /// <summary>
        /// Manage Azure Resource Manager (ARM) templates in an Azure DevTest Lab.
        /// </summary>
        public AzureLabArmTemplateTask()
        {
            WithArguments("az lab arm-template");
        }

        protected override string Description { get; set; }
        
     }
}
