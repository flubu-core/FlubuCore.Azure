
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceTask : ExternalProcessTaskBase<AzureEventhubsNamespaceTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs namespace and Authorizationrule.
        /// </summary>
        public AzureEventhubsNamespaceTask()
        {
            WithArguments("az eventhubs namespace");
        }

        protected override string Description { get; set; }
        
     }
}
