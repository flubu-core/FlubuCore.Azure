
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappIdentityRemoveTask : ExternalProcessTaskBase<AzureFunctionappIdentityRemoveTask>
     {
        
        /// <summary>
        /// Disable functionapp's managed service identity.
        /// </summary>
        public AzureFunctionappIdentityRemoveTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp identity remove");
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
