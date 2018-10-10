
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayTask : ExternalProcessTaskBase<AzureRelayWcfrelayTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service WCF Relay and Authorization Rule.
        /// </summary>
        public AzureRelayWcfrelayTask()
        {
            WithArguments("az relay wcfrelay");
        }

        protected override string Description { get; set; }
        
     }
}
