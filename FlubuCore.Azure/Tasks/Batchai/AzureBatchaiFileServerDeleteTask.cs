
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiFileServerDeleteTask : ExternalProcessTaskBase<AzureBatchaiFileServerDeleteTask>
     {
        
        /// <summary>
        /// Delete a file server.
        /// </summary>
        public AzureBatchaiFileServerDeleteTask(string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai file-server delete");
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

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureBatchaiFileServerDeleteTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureBatchaiFileServerDeleteTask Yes(string yes = null)
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
