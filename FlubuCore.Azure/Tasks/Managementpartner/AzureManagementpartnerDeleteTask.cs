
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managementpartner
{
     public partial class AzureManagementpartnerDeleteTask : ExternalProcessTaskBase<AzureManagementpartnerDeleteTask>
     {
        
        /// <summary>
        /// Delete the Microsoft Partner Network(MPN) ID of the current authenticated user or service principal.
        /// </summary>
        public AzureManagementpartnerDeleteTask(string partnerId = null)
        {
            WithArguments("az managementpartner delete");
WithArguments("--partner-id");
            if (!string.IsNullOrEmpty(partnerId))
            {
                 WithArguments(partnerId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
