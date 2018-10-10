
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayDeleteTask : ExternalProcessTaskBase<AzureRelayWcfrelayDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayDeleteTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay wcfrelay delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--namespace-name");
            if (!string.IsNullOrEmpty(namespaceName))
            {
                 WithArguments(namespaceName);
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
