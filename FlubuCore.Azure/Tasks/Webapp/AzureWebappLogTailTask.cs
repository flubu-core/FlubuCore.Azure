
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappLogTailTask : ExternalProcessTaskBase<AzureWebappLogTailTask>
     {
        
        /// <summary>
        /// Start live log tracing for a web app.
        /// </summary>
        public AzureWebappLogTailTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp log tail");
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
        /// By default all live traces configured by 'az webapp log config' will be shown, but you can scope to certain providers/folders, e.g. 'application', 'http', etc. For details, check out <a href="https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream">https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream</a>.
        /// </summary>
        public AzureWebappLogTailTask Provider(string provider = null)
        {
            WithArguments("--provider");
            if (!string.IsNullOrEmpty(provider))
            {
                 WithArguments(provider);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappLogTailTask Slot(string slot = null)
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
