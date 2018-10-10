
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureHanainstanceTask : ExternalProcessTaskBase<AzureHanainstanceTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Azure SAP HANA Instance.
        /// </summary>
        public AzureHanainstanceTask()
        {
            WithArguments("az hanainstance");
        }

        protected override string Description { get; set; }
        
     }
}
