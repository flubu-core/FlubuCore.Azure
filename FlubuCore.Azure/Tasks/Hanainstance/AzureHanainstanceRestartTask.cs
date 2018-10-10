
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Hanainstance
{
     public partial class AzureHanainstanceRestartTask : ExternalProcessTaskBase<AzureHanainstanceRestartTask>
     {
        
        /// <summary>
        /// Restart a SAP HANA Instance.
        /// </summary>
        public AzureHanainstanceRestartTask(string instanceName = null ,  string resourceGroup = null)
        {
            WithArguments("az hanainstance restart");
WithArguments("--instance-name");
            if (!string.IsNullOrEmpty(instanceName))
            {
                 WithArguments(instanceName);
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
