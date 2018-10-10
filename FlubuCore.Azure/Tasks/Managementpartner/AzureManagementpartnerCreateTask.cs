
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managementpartner
{
     public partial class AzureManagementpartnerCreateTask : ExternalProcessTaskBase<AzureManagementpartnerCreateTask>
     {
        
        /// <summary>
        /// Associates a Microsoft Partner Network(MPN) ID to the current authenticated user or service principal.
        /// </summary>
        public AzureManagementpartnerCreateTask(string partnerId = null)
        {
            WithArguments("az managementpartner create");
WithArguments("--partner-id");
            if (!string.IsNullOrEmpty(partnerId))
            {
                 WithArguments(partnerId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
