
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureInteractiveTask : ExternalProcessTaskBase<AzureInteractiveTask>
     {
        
        /// <summary>
        /// Start interactive mode.
        /// </summary>
        public AzureInteractiveTask()
        {
            WithArguments("az interactive");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The colors of the shell.
        /// </summary>
        public AzureInteractiveTask Style(string style = null)
        {
            WithArguments("--style");
            if (!string.IsNullOrEmpty(style))
            {
                 WithArguments(style);
            }

            return this;
        }
     }
}
