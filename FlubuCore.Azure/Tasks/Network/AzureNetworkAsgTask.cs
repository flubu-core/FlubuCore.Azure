
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkAsgTask : ExternalProcessTaskBase<AzureNetworkAsgTask>
     {
        
        /// <summary>
        /// Manage application security groups (ASGs).
        /// </summary>
        public AzureNetworkAsgTask()
        {
            WithArguments("az network asg");
        }

        protected override string Description { get; set; }
        
     }
}
