
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionPeeringDeleteTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionPeeringDeleteTask>
     {
        
        /// <summary>
        /// Delete peering settings.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringDeleteTask(string crossConnectionName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network cross-connection peering delete");
WithArguments("--cross-connection-name");
            if (!string.IsNullOrEmpty(crossConnectionName))
            {
                 WithArguments(crossConnectionName);
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
