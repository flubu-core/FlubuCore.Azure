
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappWebjobContinuousStopTask : ExternalProcessTaskBase<AzureWebappWebjobContinuousStopTask>
     {
        
        /// <summary>
        /// Stop a specific continuous webjob.
        /// </summary>
        public AzureWebappWebjobContinuousStopTask(string name = null ,  string resourceGroup = null ,  string webjobName = null)
        {
            WithArguments("az webapp webjob continuous stop");
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

WithArguments("--webjob-name");
            if (!string.IsNullOrEmpty(webjobName))
            {
                 WithArguments(webjobName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappWebjobContinuousStopTask Slot(string slot = null)
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
