
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappCorsRemoveTask : ExternalProcessTaskBase<AzureWebappCorsRemoveTask>
     {
        
        /// <summary>
        /// Remove allowed origins.
        /// </summary>
        public AzureWebappCorsRemoveTask(string allowedOrigins = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp cors remove");
WithArguments("--allowed-origins");
            if (!string.IsNullOrEmpty(allowedOrigins))
            {
                 WithArguments(allowedOrigins);
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
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappCorsRemoveTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
