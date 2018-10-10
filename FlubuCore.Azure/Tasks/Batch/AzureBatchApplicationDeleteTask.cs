
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationDeleteTask : ExternalProcessTaskBase<AzureBatchApplicationDeleteTask>
     {
        
        /// <summary>
        /// Deletes an application.
        /// </summary>
        public AzureBatchApplicationDeleteTask(string applicationId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch application delete");
WithArguments("--application-id");
            if (!string.IsNullOrEmpty(applicationId))
            {
                 WithArguments(applicationId);
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
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureBatchApplicationDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
