
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupExistsTask : ExternalProcessTaskBase<AzureGroupExistsTask>
     {
        
        /// <summary>
        /// Check if a resource group exists.
        /// </summary>
        public AzureGroupExistsTask(string name = null)
        {
            WithArguments("az group exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
