
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureManagementpartnerTask : ExternalProcessTaskBase<AzureManagementpartnerTask>
     {
        
        /// <summary>
        /// Allows the partners to associate a Microsoft Partner Network(MPN) ID to a user or service principal in the customer's Azure directory.
        /// </summary>
        public AzureManagementpartnerTask()
        {
            WithArguments("az managementpartner");
        }

        protected override string Description { get; set; }
        
     }
}
