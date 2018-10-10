
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managementpartner
{
     public partial class AzureManagementpartnerUpdateTask : ExternalProcessTaskBase<AzureManagementpartnerUpdateTask>
     {
        
        /// <summary>
        /// Updates the Microsoft Partner Network(MPN) ID of the current authenticated user or service principal.
        /// </summary>
        public AzureManagementpartnerUpdateTask(string partnerId = null)
        {
            WithArguments("az managementpartner update");
WithArguments("--partner-id");
            if (!string.IsNullOrEmpty(partnerId))
            {
                 WithArguments(partnerId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
